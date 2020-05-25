using System;

namespace basic_csharp.classesAndMethods{
    class ValueVsReference{
        public class Dependent{
            public string Name;
            public int Age;
        }
        public static void Run(){
            int number = 3;
            int numberCopy = number;
            System.Console.WriteLine("Number: {0}", number);
            System.Console.WriteLine("Number Copy: {0}", numberCopy);
            number++;
            System.Console.WriteLine("Number: {0}", number);
            System.Console.WriteLine("Number Copy: {0}", numberCopy);
            Dependent dependent = new Dependent{
                Name = "Beto",
                Age = 20
            };
            Dependent dependentCopy = dependent;
            System.Console.WriteLine("Dependent Name = {0}, Age = {1}", dependent.Name, dependent.Age);
            System.Console.WriteLine("Dependent Copy Name = {0}, Age = {1}", dependentCopy.Name, dependentCopy.Age);
            dependentCopy.Name = "Renata";
            dependent.Age = 21;
            System.Console.WriteLine("Dependent Name = {0}, Age = {1}", dependent.Name, dependent.Age);
            System.Console.WriteLine("Dependent Copy Name = {0}, Age = {1}", dependentCopy.Name, dependentCopy.Age);

        }
    }
}