using System;

namespace basic_csharp.Fundamentals{
    class AssignOperators{
        public static void Run(){
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;
            System.Console.WriteLine("Num1 = {0}", num1);

            int a = 1;

            //assigned by value
            int b = a;

            a++;
            b--;

            System.Console.WriteLine("a = {0}", a);
            System.Console.WriteLine("b = {0}", b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.name = "John";
            
            //assigned by reference
            dynamic d  = c;
            d.name = "Mary";

            System.Console.WriteLine("c.name = {0}", c.name);
            System.Console.WriteLine("d.name = {0}", d.name);

        }
    }
}