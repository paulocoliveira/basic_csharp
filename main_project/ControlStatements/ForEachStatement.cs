using System;

namespace basic_csharp.ControlStatements{
    class ForEachStatement{
        public static void Run(){
            var word = "Hello!";
            foreach(var letter in word){
                System.Console.WriteLine(letter);
            }

            var students = new string[] {"Ana", "Bia", "Carlos"};

            foreach(string student in students){
                System.Console.WriteLine(student);
            }
        }
    }
}