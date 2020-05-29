using System;

namespace basic_csharp.Fundamentals{
    class Interpolation{
        public static void Run(){
            string name = "Notebook Gamer";
            string brand = "Dell";
            double price = 5800.00;

            //using concatenation
            System.Console.WriteLine("The " + name + " from " + brand + " costs " + price + ".");

            //using interpolation
            System.Console.WriteLine("The {0} from {1} costs {2}.", name, brand, price);

            //using interpolation with modificator
            System.Console.WriteLine($"The {name} from {brand} costs {price}.");
            System.Console.WriteLine($"1 + 1 = {1+1}");
        }
    }
}