using System;
using System.Collections.Generic;
using basic_csharp.ClassesAndMethods;

namespace basic_csharp.AdvancedTopics{
    
    public class Box<T>{
        T privateValue;
        public T Thing {get; set;}

        public Box(T thing){
            Thing = thing;
            privateValue = thing;
        }

        public T genericMethod(T value){
            return new Random().Next(0,2) == 0 ? Thing : value;
        }

        public T GetValue(){
            return privateValue;
        }
    }

    class IntBox : Box<int>{
        public IntBox() : base(0){

        }
    }

    class ProductBox : Box<Product>{
        public ProductBox() : base(new Product()){

        }
    }

    class Generics{
        public static void Run(){
            var box1 = new Box<int>(1000);
            System.Console.WriteLine(box1.genericMethod(33));

            var box2 = new Box<string>("Constructor");
            System.Console.WriteLine(box2.genericMethod("Método"));
            
            var box3 = new ProductBox();
            System.Console.WriteLine(box3.Thing.GetType().Name);
        }
    }
}