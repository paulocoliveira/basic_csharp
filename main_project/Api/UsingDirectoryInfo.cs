using System;
using System.IO;

namespace basic_csharp.Api{
    class UsingDirectoryInfo{
        public static void Run(){
            var directory = @"D:/Github/basic_csharp/main_project";

            var dirInfo = new DirectoryInfo(directory);

            System.Console.WriteLine("\n\n===== Files =====");
            var files = dirInfo.GetFiles();
            foreach (var file in files){
                System.Console.WriteLine(file);
            }

            System.Console.WriteLine("\n\n===== Folders =====");
            var folders = dirInfo.GetDirectories();
            foreach (var folder in folders ){
                System.Console.WriteLine(folder);
            }

            System.Console.WriteLine("\n\n===== Infos =====");
            System.Console.WriteLine(dirInfo.CreationTime);
            System.Console.WriteLine(dirInfo.FullName);
            System.Console.WriteLine(dirInfo.Root);
            System.Console.WriteLine(dirInfo.Parent);
            System.Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}