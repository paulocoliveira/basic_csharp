using System;
using System.Collections.Generic;
using basic_csharp.Exercises.Module7.Models;

namespace basic_csharp.Exercises.Module7{

    class Exercise08{
        /*
        * Continuing with Person algorithm, we will have manager and coordinator roles. They will have a 
        * common method to update salary. Manager will have a bonus of 20% and coordinator 10%.
        * Show list with name, role and salary of them.
        */
        public static void Run(){
            var people = new List<Person>{
                new Person("Pedro", "Staff", 299.99),
                new Manager("André", "Manager", 300.00),
                new Person("Ana", "Staff", 300.01),
                new Person("Jorge", "Staff", 150.50),
                new Person("Ana", "Staff", 521.53),
                new Person("Júlia", "Staff", 1822.58),
                new Manager("Márcio", "Manager", 100.00),
                new Person("Paulo", "Staff", 1000.00),
                new Coordinator("Lílian", "Coordinator", 2750.00),
                new Coordinator("Urbano", "Coordinator", 2000.00)
            };
            
            foreach(var person in people){
                person.readjustSalary();
                person.bonus();
                person.informSalary();
            }

        }
    }
}