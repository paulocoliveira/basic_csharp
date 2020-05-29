using System;

namespace basic_csharp.ControlStatements{
    class UsingContinue{
        public static void Run(){
            int range = 30;
            System.Console.WriteLine("Even numbers between 1 and {0}!", range);
            for(int i=1;i<=range;i++){
                if (i % 2 == 1){
                    continue;
                }
                System.Console.Write(i + " ");
            }
        }
    }
}