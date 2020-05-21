using System;

namespace basic_csharp.classesAndMethods{
    class Person{
        public string Name;
        public int Age;

        public string Present(){
            return string.Format($"Hi! I am {Name} and I am {Age} years old.");
        }

        public void PresentInConsole(){
            System.Console.WriteLine(Present());
        }

        public void Erase(){
            Name = "";
            Age = 0;
        }
    }
}