using System;
using System.Collections.Generic;
using basic_csharp.Exercises.Module9.Models;
using basic_csharp.Exercises.Module9.Exceptions;

namespace basic_csharp.Exercises.Module9{
    class Exercise09{
        /*
        * Based on exercise 8, read a list of 10 employees and throw an exception if
        * an employee has a salary of 2000, showing name, role and salary.
        */
        public static void Run(){
            var people = new List<Person>{
                new Person("Pedro", "Staff", 299.99),
                new Manager("André", "Manager", 300.00),
                new Person("Ana", "Staff", 300.01),
                new Person("Jorge", "Staff", 2000.00),
                new Person("Ana", "Staff", 521.53),
                new Person("Júlia", "Staff", 1822.58),
                new Manager("Márcio", "Manager", 100.00),
                new Person("Paulo", "Staff", 1000.00),
                new Coordinator("Lílian", "Coordinator", 2750.00),
                new Coordinator("Urbano", "Coordinator", 2000.00)
            };
            
            foreach(var person in people){
                try{
                    person.ValidateSalary();
                } catch(TwoThousandSalaryException ttex){
                    System.Console.WriteLine(ttex.Message);
                }
            }
        }

    }
}