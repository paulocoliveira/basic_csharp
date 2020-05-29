using System;

namespace basic_csharp.MethodsAndFunctions{
    
    public static class IntExtensions{
        public static int Sum(this int number1, int number2){
            return number1 + number2;
        }

        public static int Subtraction(this int number1, int number2){
            return number1 - number2;
        }
    }
    class ExtensionMethods{
        
        
        public static void Run(){
            int number = 5;
            System.Console.WriteLine(number.Sum(3));
            System.Console.WriteLine(number.Subtraction(10));
            System.Console.WriteLine(2.Sum(3));
            System.Console.WriteLine(2.Subtraction(4));
        }
    }
}