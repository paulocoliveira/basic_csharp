using System;

namespace basic_csharp.Exercises.Module3{
    class Exercise01{
        /*
        * Create an algorithm to verify if a number is even or odd.
        */
        public static void Run(){
            
            Console.Write("Type a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0){
                System.Console.WriteLine("{0} is even.", number);
            } else{
                System.Console.WriteLine("{0} is odd.", number);
            }
        }
    }
}