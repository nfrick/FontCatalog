using DataLayer;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace RemoveFromDB {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new FontInfosEntities()) {
                //Console.WriteLine("Selecting paths");
                //foreach (var path in ctx.FontsPaths) {
                //    Console.WriteLine(path.Path);
                //    foreach (var font in ctx.Fonts.Where(f => f.Path == path.Path)) {
                //        if (File.Exists(font.FullName)) continue;
                //        Console.WriteLine($"\t{font.FullName}");
                //        ctx.Fonts.Remove(font);
                //    }
                //}
                //if (ctx.ChangeTracker.HasChanges()) {
                //    Console.WriteLine("Saving changes");
                //    ctx.SaveChanges();
                //}

                //long count = 0;
                
                foreach (var font in ctx.Fonts) {
                    
                    var file = new FileInfo(font.FullName);
                    Console.WriteLine($"{font.FileName}\t{file.LastWriteTimeUtc}");
                    font.FileDate = file.LastWriteTimeUtc;
                    font.FileSize = (int)file.Length;
                }
                Console.WriteLine("Saving...");
                ctx.SaveChanges();
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}