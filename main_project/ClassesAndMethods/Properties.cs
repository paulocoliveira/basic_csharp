using System;

namespace basic_csharp.ClassesAndMethods{
    public class CarOptionals{
        double discount = 0.1;
        string name;
        public string Name{
            get{
                return "Optional: " + name;
            }
            set{
                name = value;
            }
        }

        //Self-implemented Propertie
        public double Price{get; set;}
        
        //read only
        public double PriceWithDiscount{
            get => Price - (discount * Price);
        }

        public CarOptionals(){
            
        }

        public CarOptionals(string name, double price){
            Name = name;
            Price = price;
        }
    }
    class Properties{
        public static void Run(){
            var optional1 = new CarOptionals("Air Conditioner", 3499.90);
            System.Console.WriteLine(optional1.Name);
            System.Console.WriteLine(optional1.Price);
            System.Console.WriteLine(optional1.PriceWithDiscount);
            var optional2 = new CarOptionals();
            optional2.Name = "Electric Steering";
            optional2.Price = 2349.90;
            System.Console.WriteLine(optional2.Name);
            System.Console.WriteLine(optional2.Price);
            System.Console.WriteLine(optional2.PriceWithDiscount);
        }
    }
}