using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_csharp.Collections{
    class UsingQueues{
        public static void Run(){
            var queue = new Queue<string>();
            queue.Enqueue("Paulo");
            queue.Enqueue("César");
            queue.Enqueue("Joana");
            queue.Enqueue("César");
            System.Console.WriteLine(queue.Peek());
            System.Console.WriteLine(queue.Count);
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.Count);

            foreach (var person in queue){
                System.Console.WriteLine(person);
            }

            var mix = new Queue();
            mix.Enqueue(3);
            mix.Enqueue("Item");
            mix.Enqueue(true);
            mix.Enqueue(3.14);

            System.Console.WriteLine(mix.Contains("item"));
            System.Console.WriteLine(mix.Contains("Item"));
        }
    }
}