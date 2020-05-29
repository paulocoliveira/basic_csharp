using System;
using System.Globalization;

namespace basic_csharp.Exercises{
    class Exercise04{
        /*
        * Create an algorithm to calculate anf display the readjusted salary of 10 employees, according to the below rules:
        * 1. Salary <= 300, 50% of readjustment
        * 2. Salary > 300, 30% of readjustment
        * Use OO to implement following the below rules:
        * 1. It should contain a class Person, with name and salary attributes
        * 2. It should have the method to readjust the salary
        * 3. It should have the method to print the name and the readjusted salary
        */
        public static void Run(){
            int collected = 1;
            int numberOfPeople = 3;

            while (collected <= numberOfPeople){
                Console.Write("Type your name: ");
                string name = Console.ReadLine();

                Console.Write("Type your salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Person p = new Person();
                p.Name = name;
                p.Salary = salary;
                double readjustedSalary = p.readjustSalary();
                p.informNewSalary(readjustedSalary);
                collected++;
            }
        }
    }

    class Person{
        public string Name;
        public double Salary;

        public double readjustSalary(){
            double adjust30 = 0.3;
            double adjust50 = 0.5;
            double readjustment = 0.0;
            if (Salary >= 300.00){
                readjustment = adjust30;
            } else{
                readjustment = adjust50;
            }
            double newSalary = Salary + (Salary*readjustment);
            return newSalary;
        }

        public void informNewSalary(double newSalary){
            System.Console.WriteLine($"{Name} has new salary ${newSalary.ToString("F2")}.");
        }
    }
}
