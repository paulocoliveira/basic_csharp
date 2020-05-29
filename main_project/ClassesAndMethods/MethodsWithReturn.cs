using System;

namespace basic_csharp.ClassesAndMethods{
        
    class CommonCalculator{
        public int sum(int a, int b){
            return a + b;
        }

        public int subtraction(int a, int b){
            return a - b;
        }

        public int multiplication(int a, int b){
            return a * b;
        }

        public int division(int a, int b){
            return a / b;
        }
    }
    
    
    class ChainCalculator{
        int memory;

        public ChainCalculator sum(int a){
            memory += a;
            return this;
        }

        public ChainCalculator subtraction(int a){
            memory -= a;
            return this;
        }

        public ChainCalculator multiplication(int a){
            memory *= a;
            return this;
        }

        public ChainCalculator division(int a){
            memory /= a;
            return this;
        }

        public ChainCalculator erase(){
            memory = 0;
            return this;
        }

        public ChainCalculator printResult(){
            System.Console.WriteLine(memory);
            return this;
        }

        public int result(){
            return memory;
        }

    }
    
    class MethodsWithReturn{
        public static void Run(){
            var commonCalc = new CommonCalculator();
            var result = commonCalc.sum(5, 5);
            System.Console.WriteLine(result);
            System.Console.WriteLine(commonCalc.subtraction(2, 7));
            System.Console.WriteLine(commonCalc.multiplication(4, 4));
            System.Console.WriteLine(commonCalc.division(525, 25));

            var chainCalc = new ChainCalculator();
            chainCalc.sum(3).multiplication(3).printResult().erase().printResult();
        }
    }
}