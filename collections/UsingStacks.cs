using System;
using System.Collections;

namespace basic_csharp.collections{
    class UsingStacks{
        public static void Run(){
            var stack = new Stack();
            stack.Push(3);
            stack.Push("a");
            stack.Push(true);
            stack.Push(3.14f);

            foreach(var item in stack){
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine($"\n Pop: {stack.Pop()}");

            foreach(var item in stack){
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine($"\n Count: {stack.Count}");
            System.Console.WriteLine($"\n Peek: {stack.Peek()}");
            System.Console.WriteLine($"\n Count: {stack.Count}");

        }
    }
}