#!/usr/bin/env dart
// snap_cs.dart — Scan all .cs files in CWD and generate codesnap PNGs
// Usage: dart snap_cs.dart [optional: root_dir]

import 'dart:io';

const String csharpIcon = ''; // nf-md-language_csharp (U+F031B)
const String watermark = 'Utsav Pokharel';
const String font = 'JetBrainsMono Nerd Font';
const String outputDir = 'images';

/// Build a display name for the title and output filename.
/// For a file nested inside a subdir relative to [root], returns "subdir :: filename"
/// For a top-level file, returns just "filename" (no prefix).
String buildName(String rootPath, String filePath) {
  final root = Directory(rootPath).absolute.path;
  final abs = File(filePath).absolute.path;

  // relative path from root, e.g. "strings/characters.cs" or "Program.cs"
  String rel = abs.replaceFirst(root, '').replaceAll(RegExp(r'^[/\\]'), '');

  final parts = rel.split(RegExp(r'[/\\]'));
  final filename = parts.last.replaceAll('.cs', '');

  if (parts.length == 1) {
    // top-level file
    return filename;
  } else {
    // nested: use immediate parent dir only
    final dir = parts[parts.length - 2];
    return '$dir :: $filename';
  }
}

/// Convert a display name like "strings :: characters" to a safe filename.
String toOutputFilename(String name) {
  return name.replaceAll(' :: ', '_').replaceAll(RegExp(r'[^\w\-]'), '_');
}

Future<void> main(List<String> args) async {
  final rootPath = args.isNotEmpty ? args[0] : Directory.current.path;
  final root = Directory(rootPath);

  if (!root.existsSync()) {
    stderr.writeln('Error: directory "$rootPath" does not exist.');
    exit(1);
  }

  // Ensure output dir exists
  final out = Directory(outputDir);
  if (!out.existsSync()) {
    out.createSync(recursive: true);
    print('Created output directory: $outputDir/');
  }

  // Collect all .cs files recursively
  final csFiles =
      root
          .listSync(recursive: true, followLinks: false)
          .whereType<File>()
          .where((f) => f.path.endsWith('.cs'))
          .toList()
        ..sort((a, b) => a.path.compareTo(b.path));

  if (csFiles.isEmpty) {
    print('No .cs files found in: $rootPath');
    exit(0);
  }

  print('Found ${csFiles.length} .cs file(s). Generating snapshots...\n');

  int success = 0;
  int failed = 0;
  int skipped = 0;

  for (final file in csFiles) {
    final name = buildName(rootPath, file.path);
    final safeName = toOutputFilename(name);
    final outputPath = '$outputDir/$safeName.png';
    final title = '$csharpIcon $name                           Utsav Pokharel';

    print('  → $name');
    // Check if output file exists and compare modification dates
    final outputFile = File(outputPath);
    if (outputFile.existsSync()) {
      final sourceModified = await file.lastModified();
      final outputModified = await outputFile.lastModified();

      // Skip if source file hasn't changed since last capture
      if (sourceModified.isBefore(outputModified) ||
          sourceModified.isAtSameMomentAs(outputModified)) {
        final readableTime = outputModified.toString().split('.')[0];
        print('     ℹ no change in $name since $readableTime');
        skipped++;
        continue;
      }
    }
    final result = await Process.run('codesnap', [
      '-f',
      file.path,
      '--title',
      title,
      '--title-font-family',
      font,
      '--title-color',
      '#ffffff',
      '--code-font-family',
      font,
      '--has-line-number',
      '--line-number-color',
      '#495162',
      '--mac-window-bar',
      'true',
      '-w',
      watermark,
      '--watermark-font-family',
      'Pacifico',
      '--watermark-color',
      '#ffffffaa',
      '--background',
      '#1a1b26',
      '--shadow-radius',
      '20',
      '--shadow-color',
      '#00000060',
      '--margin-x',
      '2',
      '--margin-y',
      '2',
      '-o',
      outputPath,
    ]);

    if (result.exitCode == 0) {
      print('     ✓ Saved: $outputPath');
      success++;
    } else {
      stderr.writeln('     ✗ Failed: ${file.path}');
      if ((result.stderr as String).isNotEmpty) {
        stderr.writeln('       ${result.stderr}');
      }
      if ((result.stdout as String).isNotEmpty) {
        stderr.writeln('       ${result.stdout}');
      }
      failed++;
    }
  }

  print('\nDone. $success succeeded, $failed failed, $skipped skipped.');
}
