using System;
using System.Globalization;

namespace basic_csharp.Exercises.Challenge.Models{
    public class Person{
        public string Name;
        public string Role;
        public double Salary;

        public Person(string name, string role, double salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }

        protected double ChangeSalary(double value){
            Salary = value;
            return Salary;
        }
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
            return ChangeSalary(newSalary);
        }

        public void informSalary(){
            System.Console.WriteLine($"{Name} - {Role} - ${Salary.ToString("F2")}.");
        }

        public virtual double bonus(){
            double adjustPercent = 0.0;
            double newSalary = Salary + (Salary*adjustPercent);
            return ChangeSalary(newSalary);
        }
    }
}