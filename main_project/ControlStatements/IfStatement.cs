using System;

namespace basic_csharp.ControlStatements{
    class IfStatement{
        public static void Run(){
            bool goodBehavior = false;
            Console.Write("Type student grade: ");
            string enteredData = Console.ReadLine();

            Double.TryParse(enteredData, out double grade);

            Console.Write("Has the student a good behavior (y/n)? ");
            enteredData = Console.ReadLine();

            goodBehavior = enteredData.ToLower() == "y";
            
            if (grade >= 9.0 && goodBehavior){
                System.Console.WriteLine("Pass with Merit!");
            }
        }
    }
}
