using System;

namespace basic_csharp.classesAndMethods{
    
    public class Product{
        public string Name;
        public double Price;
        public static double Discount = 0.1;

        public Product(string name, double price, double discount){
            Name = name;
            Price = price;
            Discount = discount;
        }

        public Product(){

        }

        public double CalculateDiscount(){
            return Price - (Price * Discount);
        }
    }
    
    class StaticAttributes{
        public static void Run(){
            var product1 = new Product("Pen", 3.0, 0.1);
            var product2 = new Product(){
                Name = "Pencil",
                Price = 5.0
                //Discount = 0.5
            };

            Product.Discount = 0.5;

            System.Console.WriteLine("Price with discount: {0}", product1.CalculateDiscount());
            System.Console.WriteLine("Price with discount: {0}", product2.CalculateDiscount());

            Product.Discount = 0.1;
            
            System.Console.WriteLine("Price with discount: {0}", product1.CalculateDiscount());
            System.Console.WriteLine("Price with discount: {0}", product2.CalculateDiscount());

        }
    }
}