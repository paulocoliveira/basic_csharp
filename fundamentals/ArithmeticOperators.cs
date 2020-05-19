using System;

namespace basic_csharp.fundamentals{
    class ArithmeticOperators{
        public static void Run(){
            var price = 1000.0;
            var tax = 355;
            var discount = 0.1;

            double total = price + tax;
            var totalWithDiscount = total - (total * discount);

            System.Console.WriteLine("The final price is {0}.", totalWithDiscount);

            // MBI

            double weight = 91.2;
            double height = 1.82;
            double bmi = weight / Math.Pow(height, 2);

            System.Console.WriteLine("BMI is {0}.", bmi);

            // odd or even

            int even = 24;
            int odd = 55;

            System.Console.WriteLine("{0}/2 has {1} as remainder.", even, even%2);
            System.Console.WriteLine("{0}/2 has {1} as remainder.", odd, odd%2);
        }
    }
}