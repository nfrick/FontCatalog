using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FontCatalogConsole {
    class Program {
        private static List<string> _errors;

        static void Main(string[] args) {
            _errors = new List<string>();

            RemoveObsoleteFoldersFromDb(args[0]);
            ProcessFolder(args[0]);

            Console.WriteLine(@"---------------------------------");

            if (_errors.Any()) {
                Console.WriteLine("\n\nERRORS");
                foreach (var error in _errors.OrderBy(e => e))
                    Console.WriteLine(error);
            }
            Console.WriteLine("\n\nPress ENTER");
            Console.ReadLine();
        }

        private static void RemoveObsoleteFoldersFromDb(string folder) {
            using (var ctx = new FontInfosEntities()) {
                var foldersInDb = ctx.Folders.Where(f => f.Path.StartsWith(folder)).ToList();
                if (!foldersInDb.Any()) return;
                // Remove empty folders and folders than no longer exist
                var obsoleteFolders = foldersInDb
                    .Where(f => !f.Fonts.Any() || !Directory.Exists(f.Path)).ToList();
                ctx.Folders.RemoveRange(obsoleteFolders);
                ctx.SaveChanges();
            }
        }

        private static void ProcessFolder(string folder) {
            // Recurse into subdirectories of this directory.
            var subFolders = Directory.GetDirectories(folder);
            foreach (var subFolder in subFolders)
                ProcessFolder(subFolder);

            ProcessFiles(folder);
        }

        private static void ProcessFiles(string folder) {
            // Get the list of files found in the directory.
            var dir = new DirectoryInfo(folder);
            var files = dir.GetFiles("*.?tf").ToList();
            var fileCount = files.Count;

            using (var ctx = new FontInfosEntities()) {
                var FolderInDb = ctx.Folders.FirstOrDefault(f => f.Path == folder) ?? new Folder() { Path = folder };
                if (FolderInDb.Fonts.Any()) {
                    var fontsInDb = FolderInDb.Fonts;
                    // remove from DB fonts not in folder
                    var filesHashSet = new HashSet<string>(files.Select(x => x.FullName));
                    var ObsoleteFonts = fontsInDb.Where(f => !filesHashSet.Contains(f.FullName)).ToList();
                    if (ObsoleteFonts.Any()) {
                        ctx.Fonts.RemoveRange(ObsoleteFonts);
                        ctx.SaveChanges();
                    }

                    // do not process fonts already in database
                    var fontsHashSet = new HashSet<string>(fontsInDb.Select(f => f.FullName));
                    files.RemoveAll(f => fontsHashSet.Contains(f.FullName));
                }

                if (!files.Any()) {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n{folder} --- {fileCount}");
                    return;
                }

                var fonts = files.Select(f => new FontInfo(f, FolderInDb));

                try {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{folder} --- {fileCount} --- {fonts.Count()}");
                    ctx.Fonts.AddRange(fonts);
                    ctx.SaveChanges();
                }
                catch (Exception ex) {
                    _errors.Add(folder);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}