using System;

namespace basic_csharp.MethodsAndFunctions{
    
    delegate double Operation(double x, double y);

    class LambdaDelegate{
        public static void Run(){
            Operation sum = (x, y) => x + y;
            Operation subtraction = (x, y) => x - y;
            Operation multiplication = (x, y) => x * y;

            System.Console.WriteLine(sum(3,3));
            System.Console.WriteLine(subtraction(5,2));
            System.Console.WriteLine(multiplication(12,8));
        }
    }
}