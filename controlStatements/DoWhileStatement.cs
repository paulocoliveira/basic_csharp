using System;

namespace basic_csharp.controlStatements{
    class DoWhileStatement{
        public static void Run(){
            string enteredData;

            do{
                System.Console.Write("What is your name? ");
                enteredData = Console.ReadLine();
                System.Console.WriteLine("Welcome {0}!!!", enteredData);
                System.Console.WriteLine("Continue (y/n)? ");
                enteredData = Console.ReadLine();
            } while (enteredData.ToLower() == "y");
        }
    }
}