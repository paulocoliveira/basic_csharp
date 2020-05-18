using System;

namespace basic_csharp.fundamentals{
    class VariablesAndConstants{
        public static void Run(){
            
            //calculating circle area
            double radius = 4.5;
            const double PI = 3.14;

            radius = 5.5;

            double area = PI * radius * radius;
            System.Console.WriteLine("Area is: " + area);

            //variable basic types

            bool isRaining = true;

            System.Console.WriteLine("Is it raining? " + isRaining);

            byte age = 45;
            System.Console.WriteLine("Age: " + age);

            sbyte goalDifference = sbyte.MinValue;
            System.Console.WriteLine("Goal Difference: " + goalDifference);

            short salary = short.MaxValue;
            System.Console.WriteLine("Salary: " + salary);

            int minIntegerValue = int.MinValue;
            System.Console.WriteLine("Min Integer Value: " + minIntegerValue);

            uint brazilPopulation = 207_600_000;
            System.Console.WriteLine("Brazil Population: " + brazilPopulation);

            long minLongValue = long.MinValue;
            System.Console.WriteLine("Min Long Value: " + minLongValue);

            ulong worldwidePopulation = 7_600_000_000;
            System.Console.WriteLine("Worldwide Population: " + worldwidePopulation);

            float computerPrice = 1299.99f;
            System.Console.WriteLine("Computer Price is: " + computerPrice);

            double appleMarketValue = 1_000_000_000_000.00;
            System.Console.WriteLine("Apple Market Value: " + appleMarketValue);

            decimal distanceAmongStars = decimal.MaxValue;
            System.Console.WriteLine("Distance Among Stars: " + distanceAmongStars);

            char letter = 'b';
            System.Console.WriteLine("Letter: " + letter);

            string text = "Welcome to C#!";
            System.Console.WriteLine(text);
        }

    }
    
}