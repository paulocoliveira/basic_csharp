using System;
using System.IO;

namespace basic_csharp.Api{
    
    class UsingFileInfo{
        
        public static void RemoveIfExists(params string[] paths){
            foreach (var path in paths){
                FileInfo file = new FileInfo(path);
                if (file.Exists){
                    file.Delete();
                }
            }
        }
        
        public static void Run(){
            var originPath = @"~/origin_file.txt".ParseHome();
            var destinyPath = @"~/destiny_file.txt".ParseHome();
            var copyPath = @"~/copy_file.txt".ParseHome();

            RemoveIfExists(originPath, destinyPath, copyPath);

            using (StreamWriter sw = File.CreateText(originPath)){
                sw.WriteLine("Origin File!!!");
            }

            FileInfo origin = new FileInfo(originPath);
            System.Console.WriteLine(origin.Name);
            System.Console.WriteLine(origin.IsReadOnly);
            System.Console.WriteLine(origin.FullName);
            System.Console.WriteLine(origin.Extension);
            System.Console.WriteLine(origin.DirectoryName);

            origin.CopyTo(copyPath);
            origin.MoveTo(destinyPath);
                       
            
        }
    }
}