using System;
using System.Collections.Generic;
using basic_csharp.Exercises.Module6.Models;

namespace basic_csharp.Exercises.Module6{
    class Exercise05{
        /*
        * Continuing with Person algorithm, create a list with 10 people, and show the list with name and salary of them.
        */
        public static void Run(){
            var people = new List<Person>{
                new Person() {Name = "Pedro", Salary = 299.99},
                new Person() {Name = "André", Salary = 300.00},
                new Person() {Name = "Ana", Salary = 300.01},
                new Person() {Name = "Jorge", Salary = 150.50},
                new Person() {Name = "Ana", Salary = 521.53},
                new Person() {Name = "Júlia", Salary = 1822.58},
                new Person() {Name = "Márcio", Salary = 2000.00},
                new Person() {Name = "Paulo", Salary = 1000.00},
                new Person() {Name = "Lílian", Salary = 2750.00},
                new Person() {Name = "Urbano", Salary = 2000.00}
            };
            
            foreach(var person in people){
                double readjustedSalary = person.readjustSalary();
                person.informSalary(readjustedSalary);
            }
        }
    }
}