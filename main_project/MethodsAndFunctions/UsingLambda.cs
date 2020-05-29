using System;
using System.Collections.Generic;

namespace basic_csharp.MethodsAndFunctions{
    class UsingLambda{
        public static void Run(){
            Action<string> somethingInConsole = (a) => {
                System.Console.WriteLine("Lambda in C#" + a);
            };

            somethingInConsole("!!!");

            Func<int> RollTheDice = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            System.Console.WriteLine(RollTheDice());

            Func<int, string> hexConverter = number => number.ToString("X");

            System.Console.WriteLine(hexConverter(1234));

            Func<int, int, int, string> formatDate = (day, month, year) => 
                String.Format("{0:D2}/{1:D2}/{2}", day, month, year);
            
            System.Console.WriteLine(formatDate(1, 1, 2019));
        }
    }
}