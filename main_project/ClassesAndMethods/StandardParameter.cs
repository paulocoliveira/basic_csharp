using System;

namespace basic_csharp.ClassesAndMethods{
    class StandardParameter{
        public static int Sum(int a = 1, int b = 1){
            return a + b;
        }
        public static void Run(){
            System.Console.WriteLine(Sum(10, 23));
            System.Console.WriteLine(Sum(50));
            System.Console.WriteLine(Sum());
            System.Console.WriteLine(Sum(b: 7));
        }
    }
}