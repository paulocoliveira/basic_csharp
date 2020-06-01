using System;
using System.Globalization;

namespace basic_csharp.Exercises.Challenge.Models{
    public class Coordinator : Person{
        public Coordinator(string name, string role, double salary) : base(name, role, salary){

        }

        public override double bonus(){
            double adjustPercent = 0.1;
            double newSalary = Salary + (Salary*adjustPercent);
            return ChangeSalary(newSalary);
        }
    }
}