#!/usr/bin/env dart

import 'dart:io';

bool isRepo(Directory d) =>
    Process.runSync('git', [
      'rev-parse',
      '--is-inside-work-tree',
    ], workingDirectory: d.path).exitCode ==
    0;

String branch(Directory d) => Process.runSync('git', [
  'rev-parse',
  '--abbrev-ref',
  'HEAD',
], workingDirectory: d.path).stdout.toString().trim();

List<String> remotes(Directory d) => Process.runSync(
  'git',
  ['remote'],
  workingDirectory: d.path,
).stdout.toString().split(RegExp(r'\r?\n')).where((e) => e.trim().isNotEmpty).toList();

String choose(List<String> r) {
  if (r.length == 1) return r.first;

  for (var i = 0; i < r.length; i++) {
    print('[${i + 1}] ${r[i]}');
  }

  stdout.write('Choose remote: ');
  final i = int.tryParse(stdin.readLineSync() ?? '');

  if (i == null || i < 1 || i > r.length) {
    stderr.writeln('Invalid choice');
    exit(1);
  }

  return r[i - 1];
}

Future<void> push(Directory d, String remote, String branch) async {
  print('Pushing to $remote/$branch...\n');

  final p = await Process.start(
    'git',
    ['push', remote, branch],
    workingDirectory: d.path,
    runInShell: true,
  );

  // Stream output live
  stdout.addStream(p.stdout);
  stderr.addStream(p.stderr);

  final code = await p.exitCode;

  if (code != 0) {
    stderr.writeln('\nPush failed.');
    exit(code);
  }
}

void main() {
  final d = Directory.current;

  if (!isRepo(d)) {
    stderr.writeln('Not a git repo.');
    exit(1);
  }

  final r = remotes(d);
  if (r.isEmpty) {
    stderr.writeln('No remotes found.');
    exit(1);
  }

  push(d, choose(r), branch(d));
}
