using System;

namespace basic_csharp.MethodsAndFunctions{
    

    class UsingDelegates{
        delegate double Sum(double a, double b);
        delegate void PrintSum(double a, double b);
        static double MySum(double x, double y){
            return x + y;
        }
        static void MyPrintSum(double x, double y){
            System.Console.WriteLine(x + y);
        }

        public static void Run(){
            Sum operation1 = MySum;
            System.Console.WriteLine(operation1(2, 3.9));    
            PrintSum operation2 = MyPrintSum;
            operation2(5.4, 8);
            Func<double, double, double> operation3 = MySum;
            System.Console.WriteLine(operation3(2,3));
            Action<double, double> operation4 = MyPrintSum;
            operation4(7.7, 23.4);
        }
    }
}