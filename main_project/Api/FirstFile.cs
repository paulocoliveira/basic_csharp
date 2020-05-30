using System;
using System.IO;

namespace basic_csharp.Api{
    
    public static class StringExtension{
        public static string ParseHome(this string path){
            string home = (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX) 
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                return path.Replace("~", home);
        }
    }

    class FirstFile{
        public static void Run(){
            var path = @"~/first_file.txt".ParseHome();
            if (!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)){
                    sw.WriteLine("This is");
                    sw.WriteLine("my first");
                    sw.WriteLine("file!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)){
                sw.WriteLine("");
                sw.WriteLine("It is possible");
                sw.WriteLine("to add more text!");
            }
            
        }
    }
}