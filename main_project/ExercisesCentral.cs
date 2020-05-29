using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_csharp {
    public class ExercisesCentral {
        Dictionary<string, Action> Exercises;

        public ExercisesCentral(Dictionary<string, Action> exercises) {
            Exercises = exercises;    
        }

        public void SelectAndRun() {
            int i = 1;

            foreach (var exercises in Exercises) {
                Console.WriteLine("{0}) {1}", i, exercises.Key);
                i++;
            }

            Console.Write("Type exercise number (or empty to the last one): ");

            int.TryParse(Console.ReadLine(), out int num);
            bool validNum = num > 0 && num <= Exercises.Count;
            num = validNum ? num - 1 : Exercises.Count - 1;

            string exerciseName = Exercises.ElementAt(num).Key;

            Console.Write("\nRunning Exercise ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exerciseName);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", exerciseName.Length + 21)) + "\n");

            Action executar = Exercises.ElementAt(num).Value;
            try {
                executar();
            } catch(Exception e) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("An error occured: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}