using System;
using System.Globalization;

namespace basic_csharp.Exercises.Module5.Models{
    public class Person{
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

        public void informSalary(double newSalary){
            System.Console.WriteLine($"{Name} has new salary ${newSalary.ToString("F2")}.");
        }
    }
}