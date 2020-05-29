using System;

namespace basic_csharp.ObjectOriented{
    
    public class Animal{
        public string Name {get; set;}
        public Animal(string name){
            Name = name;
        }
    }

    public class Dog : Animal{
        public double Height {get; set;}

        public Dog(string name) : base(name){
            System.Console.WriteLine("Dog Initialized!");
        }

        public Dog(string name, double height) : this(name){
            Height = height;
        }

        public override string ToString(){
            return $"{Name} is {Height}cm tall!";
        }


    }
    class ThisConstructor{
        public static void Run(){
            var spike = new Dog("Spike");
            var max = new Dog("Max", 40.0);
            System.Console.WriteLine(spike);
            System.Console.WriteLine(max);
        }
    }
}