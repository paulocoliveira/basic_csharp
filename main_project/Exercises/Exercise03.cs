using System;
using System.Globalization;

namespace basic_csharp.Exercises{
    class Exercise03{
        /*
        * Create an algorithm to calculate anf display the readjusted salary of 10 employees, according to the below rules:
        * 1. Salary <= 300, 50% of readjustment
        * 2. Salary > 300, 30% of readjustment
        */
        public static void Run(){
            int collected = 1;
            int numberOfPeople = 10;
            double adjust30 = 0.3;
            double adjust50 = 0.5;
            double readjustment = 0.0;

            while (collected <= numberOfPeople){
                Console.Write("Type your salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (salary >= 300.00){
                    readjustment = adjust30;
                } else{
                    readjustment = adjust50;
                }

                double newSalary = salary + (salary*readjustment);
                
                collected++;

                System.Console.WriteLine($"Previous Salary: ${salary} - Readjustment {readjustment.ToString("P0")} - New Salary ${newSalary.ToString("F2")}.");

            }

        }
    }
}
