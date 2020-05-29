using System;

namespace basic_csharp.ControlStatements{
    class UsingBreak{
        public static void Run(){
            Random random = new Random();
            int number = random.Next(1,51);

            System.Console.WriteLine("Selected number is {0}.", number);

            for (int i = 1; i <= 50; i++){
                System.Console.Write("{0} is the selected number? ", i);
                if (number == i){
                    System.Console.WriteLine("Yes");
                    break;
                } else{
                    System.Console.WriteLine("No");
                }
            }
            System.Console.WriteLine("End!");

        }
    }
}