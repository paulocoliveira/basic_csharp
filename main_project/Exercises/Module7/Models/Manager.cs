using System;
using System.Globalization;

namespace basic_csharp.Exercises.Module7.Models{
    public class Manager : Person{
        public Manager(string name, string role, double salary) : base(name, role, salary){

        }

        public override double bonus(){
            double adjustPercent = 0.2;
            double newSalary = Salary + (Salary*adjustPercent);
            return ChangeSalary(newSalary);
        }
    }
}