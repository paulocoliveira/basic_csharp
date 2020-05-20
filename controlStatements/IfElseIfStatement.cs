using System;

namespace basic_csharp.controlStatements{
    class IfElseIfStatement{
        public static void Run(){
            System.Console.Write("Type student grade: ");
            string enteredData = Console.ReadLine();
            Double.TryParse(enteredData, out double grade);

            if (grade >= 9.0){
                System.Console.WriteLine("Pass with Merit!");
            } else if (grade >= 7.0){
                System.Console.WriteLine("Passed!");
            } else if (grade >= 5.0){
                System.Console.WriteLine("Final Exams!");
            } else{
                System.Console.WriteLine("Failed!");
            }

            System.Console.WriteLine("End");
        }
    }
}