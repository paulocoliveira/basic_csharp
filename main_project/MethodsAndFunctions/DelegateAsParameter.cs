using System;

namespace basic_csharp.MethodsAndFunctions{
    class DelegateAsParameter{

        public delegate int Operation(int x, int y);

        public static int Sum(int x, int y){
            return x + y;
        }

        public static string Calculator(Operation op, int x, int y){
            var result = op(x, y);
            return "Result: " + result;
        }

        public static void Run(){
            Operation subtraction = (int x, int y) => x - y;
            System.Console.WriteLine(Calculator(subtraction, 3,2));
            System.Console.WriteLine(Calculator(Sum, 3,2));
        }
    }
}