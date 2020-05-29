using System;
using System.Collections.Generic;

namespace basic_csharp.ObjectOriented{
    interface BinaryOperation{
        int Operation(int a, int b);
    }

    class Sum : BinaryOperation{
        public int Operation(int a, int b){
            return a + b;
        }
    }

    class Subtraction : BinaryOperation{
        public int Operation(int a, int b){
            return a - b;
        }
    }

    class Multiplication : BinaryOperation{
        public int Operation(int a, int b){
            return a * b;
        }
    }
    
    class Calculator{
        List<BinaryOperation> operations = new List<BinaryOperation>{
            new Sum(),
            new Subtraction(),
            new Multiplication()
        };

        public string RunOperations(int a, int b){
            string result = "";
            foreach(var op in operations){
                result += $"Using {op.GetType().Name} = {op.Operation(a,b)}\n";
            }
            return result;
        }
    }
    class Interface{
        public static void Run(){
            var calc = new Calculator();
            var result = calc.RunOperations(20, 5);
            System.Console.WriteLine(result);
        }
    }
}