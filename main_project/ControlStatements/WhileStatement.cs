using System;

namespace  basic_csharp.ControlStatements{
    class WhileStatement{
        public static void Run(){
            int hunch = 0;
            Random random = new Random();
            
            int secretNumber = random.Next(1,16);
            bool discovered = false;
            int remainAttempts = 5;
            int attempts = 0;
            
            while (remainAttempts > 0 && !discovered){
                System.Console.Write("Type your hunch: ");
                int.TryParse(Console.ReadLine(), out hunch);
                attempts++;
                remainAttempts--;
                if (hunch == secretNumber){
                    discovered = true;
                    var previousColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Found in {0} attempts!", attempts);
                    Console.BackgroundColor = previousColor;
                } else if (hunch > secretNumber){
                    System.Console.WriteLine("Secret number is smaller... Try again!");
                    System.Console.WriteLine("Remain Attempts: {0}", remainAttempts);
                } else{
                    System.Console.WriteLine("Secret number is higher... Try again!");
                    System.Console.WriteLine("Remain Attempts: {0}", remainAttempts);
                }
            }


        }
    }
}