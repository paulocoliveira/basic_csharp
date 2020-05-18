using System;

namespace basic_csharp{
    class Inference{
        public static void Run(){
            
            //using implicit variables
            var name = "Paulo";
            System.Console.WriteLine("Name: " + name);

            /*implicity variable type should be initialized
             * The bellow code will fail
             * var age;
             * age = 32;
             * System.Console.WriteLine("Age: " + age);
            */

            //declaring a variable
            int a;

            //associating variable to a value
            a = 3;

            //declaring and associating a value

            int b = 2;

            System.Console.WriteLine("a + b = " + (a + b));
        }
    }
}