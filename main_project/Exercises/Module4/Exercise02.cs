using System;

namespace basic_csharp.Exercises.Module4{
    class Exercise02{
        /*
        * Create an algorithm to inform how many people has more than 18 years.
        * The algorith should read the age of 10 people.
        */
        public static void Run(){
            int collected = 1;
            int numberOfPeople = 10;
            int moreThan18 = 0;

            while (collected <= numberOfPeople){
                Console.Write("Type your age: ");
                int.TryParse(Console.ReadLine(), out int age);
                if (age > 18){
                    moreThan18++;
                }
                collected++;
            }

            System.Console.WriteLine("The number of people that has more than 18 years is: {0}.", moreThan18);

        }
    }
}