using System;

namespace basic_csharp.fundamentals{
    class RelationalOperators{
        public static void Run(){
            System.Console.Write("Inform student grade: ");
            double.TryParse(Console.ReadLine(), out double grade);
            double passGrade = 7.0;

            System.Console.WriteLine("Invalid grade? {0}", grade > 10.0);
            System.Console.WriteLine("Invalid grade? {0}", grade < 0.0);
            System.Console.WriteLine("Perfect grade? {0}", grade == 10.0);
            System.Console.WriteLine("Can be better? {0}", grade != 10.0);
            System.Console.WriteLine("Passed? {0}", grade >= passGrade);
            System.Console.WriteLine("Final Exams? {0}", grade < passGrade);
            System.Console.WriteLine("Failed? {0}", grade <= 3.0);
        }
    }
}