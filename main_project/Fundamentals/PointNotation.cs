using System;

namespace basic_csharp.Fundamentals{
    class PointNotation{
        public static void Run(){
            string hello = "hello".ToUpper().Insert(5, " Mundo!").Replace("Mundo", "World");
            System.Console.WriteLine(hello);

            System.Console.WriteLine("Test".Length);
            
            // security navigation
            string importantValue = null;
            System.Console.WriteLine(importantValue?.Length);
        }
    }
}