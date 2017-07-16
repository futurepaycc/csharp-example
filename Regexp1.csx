/*
脚本文件，运行方式
1,用csc Regexp1.csx 的方式变异
2,增加一门语言配置(csx)，ctrl+alt+j进行选择语言运行


"code-runner.executorMap": {
      "csx":"csi $fileName",
      "csharp":"csc $fileName && $fileNameWithoutExt.exe"
},
*/

using System;
using System.Text.RegularExpressions;

string input = "1851 1999 1950 1905 2003";
string pattern = @"(?<=19)\d{2}\b";

foreach (Match match in Regex.Matches(input, pattern))
      Console.WriteLine(match.Value);