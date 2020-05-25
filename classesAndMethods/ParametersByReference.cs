using System;

namespace basic_csharp.classesAndMethods{
    class ParametersByReference{
        
        public static void ChangeRef(ref int number){
            number = number + 1000;
        }

        public static void ChangeOut(out int number1, out int number2){
            number1 = 0;
            number2 = 0;
            number1 = number1 + 15;
            number2 = number2 + 20;
        }
        public static void Run(){
            int a = 3;
            ChangeRef(ref a);
            System.Console.WriteLine(a);

            ChangeOut(out int b, out int c);
            System.Console.WriteLine($"{b} {c}");

        }
    }
}