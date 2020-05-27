using System;
using System.Collections.Generic;

namespace basic_csharp.collections{

    class UsingSets{
        public static void Run(){
            var book = new Product("Game of Thrones", 49.9);
            var cart = new HashSet<Product>();
            cart.Add(book);

            var combo = new HashSet<Product>{
                new Product("T-Shirt", 29.9),
                new Product("Game of Thrones", 99.9),
                new Product("Poster", 10)
            };

            cart.UnionWith(combo);
            System.Console.WriteLine(cart.Count);

            foreach (var item in cart){
                System.Console.WriteLine($"{item.Name} {item.Price}");
            }

            System.Console.WriteLine(cart.Count);
            cart.Add(book);
            System.Console.WriteLine(cart.Count);
        }
    }
}