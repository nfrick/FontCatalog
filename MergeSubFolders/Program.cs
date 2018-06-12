using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MergeSubFolders {
    class Program {
        private static readonly string baseDir = @"D:\AAA";
        static void Main(string[] args) {
            var subFolders = Directory.GetDirectories(baseDir);
            foreach (var subFolder in subFolders)
            //    CheckForSubFolders(subFolder);
            ProcessFolder(subFolder);
            Console.Write("Done.");
            Console.ReadLine();
        }

        static void CheckForSubFolders(string folder) {
            var subFolders = Directory.GetDirectories(folder);
            if (subFolders.Any())
                Console.WriteLine(folder);
        }

        static void ProcessFolder(string folder) {
            var dir = new DirectoryInfo(folder);
            var files = dir.GetFiles("*.?tf", SearchOption.AllDirectories)
                .ToList().Where(f => f.DirectoryName != folder);
            foreach (var file in files) {
                var newNameBase = Path.Combine(folder, file.Name);
                var newName = newNameBase;
                Console.WriteLine($"{file.FullName} --> {newName}");
                var count = 0;
                while (File.Exists(newName)) {
                    count++;
                    var pos = newNameBase.Length - 4;
                    newName = newNameBase.Insert(pos, $" ({count})");
                }
                File.Move(file.FullName, newName);
            }
        }
    }
}
