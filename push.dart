#!/usr/bin/env dart

import 'dart:io';
import 'commit.dart' as commit;

void main() {
  commit.invoke(['--push']);
}
