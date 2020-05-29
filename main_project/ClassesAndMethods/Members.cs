using System;

namespace basic_csharp.ClassesAndMethods{
    class Members{
        public static void Run(){
            Person p1 = new Person();
            p1.Name = "Paulo";
            p1.Age = 36;

            //System.Console.WriteLine($"{p1.Name} is {p1.Age} years old.");
            p1.PresentInConsole();
            p1.Erase();
            p1.PresentInConsole();


            Person p2 = new Person();
            p2.Name = "César";
            p2.Age = 21;

            var p2Presentation = p2.Present();
            System.Console.WriteLine(p2Presentation);
        }
    }
}
