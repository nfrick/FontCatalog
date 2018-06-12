using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DuplicateDeleter {
    class Program {
        static void Main(string[] args) {
            var Errors = new List<string>();
            using (var ctx = new FontInfosEntities()) {
                foreach (var dup in ctx.Duplicates.Where(
                    d => d.Folder.StartsWith(@"D:\Fonts1\Fonts Categorized\"))) {
                    Console.WriteLine(dup.Folder + dup.FileName);
                    try {
                        //File.Delete(dup.Folder + dup.FileName);
                    }
                    catch {
                        Errors.Add(dup.FileName);
                    }
                }
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
