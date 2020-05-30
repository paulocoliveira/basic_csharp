using System;
using System.IO;

namespace basic_csharp.Api{
    class Directories{
        public static void Run(){
            var newDirectory = @"~/CSharpFolder".ParseHome();
            var newDestinyDirectory = @"~/CSharpFolderDestiny".ParseHome();
            var anotherDirectory = @"D:/";

            if (Directory.Exists(newDirectory)){
                Directory.Delete(newDirectory, true);
            }

            if (Directory.Exists(newDestinyDirectory)){
                Directory.Delete(newDestinyDirectory, true);
            }

            Directory.CreateDirectory(newDirectory);
            System.Console.WriteLine(Directory.GetCreationTime(newDirectory));

            System.Console.WriteLine("===== Folders =====");
            var folders = Directory.GetDirectories(anotherDirectory);
            foreach(var folder in folders){
                System.Console.WriteLine(folder);
            }

            System.Console.WriteLine("\n\n===== Files =====");
            var files = Directory.GetFiles(anotherDirectory);
            foreach(var file in files){
                System.Console.WriteLine(file);
            }

            System.Console.WriteLine("\n\n===== Root =====");
            System.Console.WriteLine(Directory.GetDirectoryRoot(newDirectory));

            Directory.Move(newDirectory, newDestinyDirectory);

        }
    }
}