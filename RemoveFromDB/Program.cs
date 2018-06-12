using DataLayer;
using System;
using System.IO;

// Remove from DB fonts that no longer exist (as files)

namespace RemoveFromDB {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new FontInfosEntities()) {
                Console.WriteLine("Selecting paths");
                foreach (var folder in ctx.Folders) {
                    Console.WriteLine(folder.Path);
                    foreach (var font in folder.Fonts) {
                        if (File.Exists(font.FullName)) continue;
                        Console.WriteLine($"\t{font.FullName}");
                        ctx.Fonts.Remove(font);
                    }
                }
                if (ctx.ChangeTracker.HasChanges()) {
                    Console.WriteLine("Saving changes");
                    ctx.SaveChanges();
                }
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}