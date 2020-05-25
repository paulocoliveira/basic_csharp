using System;

namespace basic_csharp.classesAndMethods{
    public class Customer{
        public string Name;
        readonly DateTime BirthDate;

        public Customer(string name, DateTime birthDate){
            Name = name;
            BirthDate = birthDate;
        }
        public string GetCustomerBirthDate(){
            return String.Format("{0}/{1}/{2}", BirthDate.Day, BirthDate.Month, BirthDate.Year);
        }
    }
    class ReadOnly{
        public static void Run(){
            var customer1 = new Customer("Ana Silva", new DateTime(1987,5,22));
            System.Console.WriteLine(customer1.Name);
            System.Console.WriteLine(customer1.GetCustomerBirthDate());
        }
    }
}