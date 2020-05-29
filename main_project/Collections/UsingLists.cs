using System;
using System.Collections.Generic;

namespace basic_csharp.Collections{
    public class Product{
        public string Name;
        public double Price;

        public Product(string name, double price){
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj){
            Product anotherProduct = (Product)obj;
            bool sameName = Name == anotherProduct.Name;
            bool samePrice = Price == anotherProduct.Price;
            return sameName && samePrice;
        }

        public override int GetHashCode(){
            return Name.Length;
        }
    }

    class UsingLists{
        public static void Run(){
            var book = new Product("Game of Thrones", 49.9);
            var cart = new List<Product>();
            cart.Add(book);

            var combo = new List<Product>{
                new Product("T-Shirt", 29.9),
                new Product("Game of Thrones", 99.9),
                new Product("Poster", 10)
            };

            cart.AddRange(combo);
            System.Console.WriteLine(cart.Count);

            cart.RemoveAt(2);

            foreach (var item in cart){
                System.Console.Write(cart.IndexOf(item));
                System.Console.WriteLine($"{item.Name} {item.Price}");
            }

            System.Console.WriteLine(cart.Count);
            cart.Add(book);
            System.Console.WriteLine(cart.Count);
            System.Console.WriteLine(cart.LastIndexOf(book));
        }
    }
}