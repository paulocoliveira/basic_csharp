using System;

namespace basic_csharp.classesAndMethods{
    class Params{
        public static void Receive(params string[] people){
            foreach (var person in people){
                System.Console.WriteLine("Hi {0}!", person);
            }
        }
        public static void Run(){
            Receive("Pedro", "Manu", "Roger");

        }
    }
}