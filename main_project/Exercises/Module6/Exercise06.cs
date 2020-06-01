using System;
using System.Collections.Generic;
using basic_csharp.Exercises.Module6.Models;

namespace basic_csharp.Exercises.Module6{
    class Exercise06{
        /*
        * Continuing with Person algorithm, create a list with 10 people, remove the first three people
        * and show the list with name and salary of them.
        */
        public static void Run(){
            var people = new Queue<Person>();
            people.Enqueue(new Person() {Name = "Pedro", Salary = 299.99});
            people.Enqueue(new Person() {Name = "André", Salary = 300.00});
            people.Enqueue(new Person() {Name = "Ana", Salary = 300.01});
            people.Enqueue(new Person() {Name = "Jorge", Salary = 150.50});
            people.Enqueue(new Person() {Name = "Ana", Salary = 521.53});
            people.Enqueue(new Person() {Name = "Júlia", Salary = 1822.58});
            people.Enqueue(new Person() {Name = "Márcio", Salary = 2000.00});
            people.Enqueue(new Person() {Name = "Paulo", Salary = 1000.00});
            people.Enqueue(new Person() {Name = "Lílian", Salary = 2750.00});
            people.Enqueue(new Person() {Name = "Urbano", Salary = 2000.00});

            for (int i = 1; i <= 3; i++ ){
                people.Dequeue();
            }

            foreach(var person in people){
                double readjustedSalary = person.readjustSalary();
                person.informSalary(readjustedSalary);
            }
        }
    }
}