using System;

namespace basic_csharp.fundamentals{
    class TernaryOperators{
        public static void Run(){
            var grade = 9.0;
            bool goodBehavior = true;
            string result = grade >= 7.0 && goodBehavior ? "Passed" : "Failed";

            System.Console.WriteLine(result);
        }
    }
}