using System;
using System.IO;

namespace basic_csharp.Api{
    
    class UsingPath{
        public static void Run(){
            var file = @"~/example_path_file.txt".ParseHome();
            var folder = @"~/example_path_folder".ParseHome();

            if (!File.Exists(file)){
                using (StreamWriter sw = File.CreateText(file)){
                    sw.WriteLine("A new file was created!");
                }
            }

            if (!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            System.Console.WriteLine(Path.GetExtension(file));
            System.Console.WriteLine(Path.GetFileName(file));
            System.Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            System.Console.WriteLine(Path.GetDirectoryName(file));
            System.Console.WriteLine(Path.HasExtension(file));
            System.Console.WriteLine(Path.HasExtension(folder));
            System.Console.WriteLine(Path.GetFullPath(folder));
            System.Console.WriteLine(Path.GetPathRoot(folder));
           
            
        }
    }
}