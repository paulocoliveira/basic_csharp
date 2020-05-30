using System;
using System.IO;

namespace basic_csharp.Api{
    
    class ReadingFiles{
        public static void Run(){
            var path = @"~/reading_files.txt".ParseHome();
            
            if (!File.Exists(path)){
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine("Product;Price;Quantity");
                    sw.WriteLine("Pen;3.59;89");
                    sw.WriteLine("Erases;2.89;27");
                }
            }

            try{
                using (StreamReader sr = new StreamReader(path)){
                    var text = sr.ReadToEnd();
                    System.Console.WriteLine(text);
                }
            } catch (Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}