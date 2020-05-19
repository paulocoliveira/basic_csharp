using System;

namespace basic_csharp.fundamentals{
    class TypeCasting{
        public static void Run(){
            
            // implicit casting
            int integer = 10;
            double partial = integer;
            System.Console.WriteLine(partial);

            // explicit casting
            double grade = 9.7;
            int truncatedGrade = (int) grade;

            System.Console.WriteLine("Truncated Grade: {0}", truncatedGrade);

            // converting from string to integer
            Console.Write("How old are you? ");
            string stringAge = Console.ReadLine();
            int integerAge = int.Parse(stringAge);
            System.Console.WriteLine("Informed Age: {0}", integerAge);

            // converting using convert method
            integerAge = Convert.ToInt32(stringAge);
            System.Console.WriteLine("Informed Age: {0}", integerAge);

            // converting value without error in case it is not possible
            System.Console.Write("Type the first number: ");
            string word = Console.ReadLine();
            int.TryParse(word, out int number1);
            System.Console.WriteLine("Result 1: {0}", number1);

            // same as above but optimized
            System.Console.Write("Type the secont number: ");
            int.TryParse(Console.ReadLine(), out int number2);
            System.Console.WriteLine("Result 2: {0}", number2);


        }
    }
}