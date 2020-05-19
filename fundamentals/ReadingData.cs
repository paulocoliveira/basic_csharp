using System;
using System.Globalization;

namespace basic_csharp.fundamentals{
    class ReadingData{
        public static void Run(){
            System.Console.Write("Whats is your name? ");
            string name = Console.ReadLine();

            System.Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("How much is your salary? ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"{name} has {age} years old and receives ${salary}");
        }
    }
}