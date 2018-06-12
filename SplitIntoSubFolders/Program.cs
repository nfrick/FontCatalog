using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataLayer;

namespace SplitIntoSubFolders {
    class Program {
        static void Main(string[] args) {
            ProcessFolder(@"D:\AAA");
            Console.WriteLine("\n\n\nTerminado.");
            Console.ReadLine();
        }

        private static void ProcessFolder(string folder) {
            // Recurse into subdirectories of this directory.
            var subFolders = Directory.GetDirectories(folder);
            foreach (var subFolder in subFolders)
                ProcessFolder(subFolder);

            Write($"\n\n{folder}", ConsoleColor.Red);
            ProcessFilesByFilename(folder);
        }

        private static void ProcessFilesByFilename(string folder) {
            // Get the list of files found in the directory.
            var dir = new DirectoryInfo(folder);
            var files = dir.GetFiles("*.?tf");
            if (files.Length < 1001) {
                ProcessFilesByFamily(folder, files);
                return;
            }
            var groups = files.GroupBy(f => f.Name.Substring(0, 2).Trim().ToUpper());
            var folders = new Dictionary<string, List<FileInfo>>();
            var target = new List<FileInfo>();
            var key = "";
            var lastKey = "";

            foreach (var group in groups) {
                if (key == "")
                    key = group.Key;

                if (target.Count + group.Count() > 800) {
                    folders.Add(NewFolderName(key, lastKey), target);
                    target = new List<FileInfo>();
                    key = group.Key;
                }

                target.AddRange(group);
                if (target.Count < 400) {
                    lastKey = group.Key;
                    continue;
                }

                folders.Add(NewFolderName(key, group.Key), target);
                target = new List<FileInfo>();
                key = "";
            }
            folders.Add(NewFolderName(key, groups.Last().Key), target);

            foreach (var f in folders.Where(f => f.Value.Any())) {
                var newFolder = Path.Combine(folder, f.Key);
                Write($"\t{newFolder}", ConsoleColor.Yellow);
                Directory.CreateDirectory(newFolder);
                foreach (var file in f.Value) {
                    var newName = Path.Combine(newFolder, file.Name);
                    File.Move(file.FullName, newName);
                    Console.WriteLine($"\t\t{newName}");
                }
                ProcessFilesByFamily(newFolder);
            }
        }

        private static void Write(string text, ConsoleColor color) {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }

        private static string NewFolderName(string key1, string key2) {
            return key1 == key2 ? key1 : $"{key1}-{key2}";
        }

        private static void ProcessFilesByFamily(string folder) {
            // Get the list of files found in the directory.
            var dir = new DirectoryInfo(folder);
            ProcessFilesByFamily(folder, dir.GetFiles("*.?tf"));
        }

        private static void ProcessFilesByFamily(string folder, IEnumerable<FileInfo> files) {
            if (!files.Any()) return;

            var groups = files.Select(f => new FontInfo(f))
                .Where(f => !string.IsNullOrEmpty(f.FamilyName))
                .GroupBy(f => CleanFileName(f.FamilyName).ToUpper())
                .Where(g => g.Count() > 1);

            foreach (var group in groups) {
                var newFolder = Path.Combine(folder, group.Key);
                Directory.CreateDirectory(newFolder);
                Write($"\t{newFolder}", ConsoleColor.Yellow);

                foreach (var file in group) {
                    var newName = Path.Combine(newFolder, file.FileName);
                    File.Move(file.FullName, newName);
                    Console.WriteLine($"\t\t{newName}");
                }
            }
        }

        private static string CleanFileName(string fileName) {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty)).Trim();
        }
    }
}
