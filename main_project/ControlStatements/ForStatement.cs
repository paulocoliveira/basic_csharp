using System;

namespace basic_csharp.ControlStatements{
    class ForStatement{
        public static void Run(){
            double sum = 0.0;
            string enteredData;

            System.Console.Write("Inform the number of students of the class: ");
            enteredData = Console.ReadLine();
            int.TryParse(enteredData, out int classSize);
            
            for (int i = 1; i <= classSize; i++){
                System.Console.Write($"Inform student {i} grade: ");
                enteredData = Console.ReadLine();
                double.TryParse(enteredData, out double currentGrade);
                sum += currentGrade;
            }

            double average = classSize > 0 ? sum / classSize : 0;
            System.Console.WriteLine("Class Average = {0}", average);
        }
    }
}