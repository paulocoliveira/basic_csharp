using System;

namespace basic_csharp.fundamentals{
    class UnaryOperators{
        public static void Run(){
            var negativeValue = -5;
            var number1 = 2;
            var number2 = 3;
            var boolean = true;

            // sign inverting
            System.Console.WriteLine(-negativeValue);
            
            // logical negation
            System.Console.WriteLine(!boolean);
            
            // postfix increment operator
            number1++;
            System.Console.WriteLine(number1);

            // prefix decrement operator
            --number1;
            System.Console.WriteLine(number1);

            // precedence -- == ++
            System.Console.WriteLine(number1++ == --number2);
            System.Console.WriteLine($"{number1} {number2}");

        }
    }
}