using System;

namespace basic_csharp.controlStatements{
    class SwitchStatement{
        public static void Run(){
            System.Console.Write("Please, give a grade for my attendance from 0 to 5: ");
            int.TryParse(Console.ReadLine(), out int grade);
            switch(grade){
                case 0:
                    System.Console.WriteLine("Terrible");
                    break;
                case 1:
                case 2:
                    System.Console.WriteLine("Bad");
                    break;
                case 3:
                    System.Console.WriteLine("Regular");
                    break;
                case 4:
                    System.Console.WriteLine("Good");
                    System.Console.WriteLine("Congratulations!");
                    break;
                case 5:
                    System.Console.WriteLine("Excellent");
                    System.Console.WriteLine("Greate Job!");
                    break;
                default:
                    System.Console.WriteLine("Invalid Grade!");
                    break;
            }
            System.Console.WriteLine("Thanks for answering!");
        }
    }
}