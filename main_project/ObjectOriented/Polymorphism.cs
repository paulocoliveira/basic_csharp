using System;

namespace basic_csharp.ObjectOriented{
    
    public class Food{
        public double Weight;

        public Food(double weight){
            Weight = weight;
        }

        public Food(){
        }
    }
    public class Beans : Food{
    }

    public class Rice : Food{
    }

    public class Meat : Food{
    }

    public class Person{
        public double Weight;
        public void Eat(Food food){
            Weight += food.Weight;
        }
    }
    class Polymorphism{
        public static void Run(){
            Beans ingredient1 = new Beans();
            ingredient1.Weight = 0.3;
            Rice ingredient2 = new Rice();
            ingredient2.Weight = 0.25;
            Meat ingredient3 = new Meat();
            ingredient3.Weight = 0.3;
            Person customer = new Person();
            customer.Weight = 80.2;
            customer.Eat(ingredient1);
            customer.Eat(ingredient2);
            customer.Eat(ingredient3);
            System.Console.WriteLine($"Now, the customer weight is {customer.Weight}kg!");
        }
    }
}