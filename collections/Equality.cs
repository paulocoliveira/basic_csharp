using System;

namespace basic_csharp.collections{
    class Equality{
        public static void Run(){
            var product1 = new Product("pen", 1.89);
            var product2 = new Product("pen", 1.89);
            var product3 = product2;
            System.Console.WriteLine(product1 == product2);
            System.Console.WriteLine(product3 == product2);
            System.Console.WriteLine(product1.Equals(product2));

        }
    }
}