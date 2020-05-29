using System;

namespace basic_csharp.ClassesAndMethods{
    
    public class StaticCalculator{
        public static int sum(int a, int b){
            return a + b;
        }

        public static int multiplication(int a, int b){
            return a * b;
        }
    }
    
    class StaticMethods{
        public static void Run(){
            var result = StaticCalculator.sum(2, 2);
            System.Console.WriteLine(result);
            result = StaticCalculator.multiplication(2, 2);
            System.Console.WriteLine(result);

        }
    }
}