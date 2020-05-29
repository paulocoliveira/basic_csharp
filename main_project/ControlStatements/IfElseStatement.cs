using System;

namespace basic_csharp.ControlStatements{
    class IfElseStatement{
        public static void Run(){
            double grade = 7.0;

            if (grade >= 7.0){
                System.Console.WriteLine("Passed!");
                System.Console.WriteLine("Congratulations!!!");
            } else{
                System.Console.WriteLine("Failed!");
                System.Console.WriteLine("Final Exams!!!");
            }
        }
    }
}