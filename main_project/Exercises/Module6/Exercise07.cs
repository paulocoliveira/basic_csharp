using System;
using System.Collections;
using System.Collections.Generic;
using basic_csharp.Exercises.Module6.Models;

namespace basic_csharp.Exercises.Module6{
    class Exercise07{
        /*
        * Continuing with Person algorithm, create a list with 10 people, and show the list in the reverse order.
        */
        public static void Run(){
            Stack<Person> people = new Stack<Person>();
            people.Push(new Person() {Name = "Pedro", Salary = 299.99});
            people.Push(new Person() {Name = "André", Salary = 300.00});
            people.Push(new Person() {Name = "Ana", Salary = 300.01});
            people.Push(new Person() {Name = "Jorge", Salary = 150.50});
            people.Push(new Person() {Name = "Ana", Salary = 521.53});
            people.Push(new Person() {Name = "Júlia", Salary = 1822.58});
            people.Push(new Person() {Name = "Márcio", Salary = 2000.00});
            people.Push(new Person() {Name = "Paulo", Salary = 1000.00});
            people.Push(new Person() {Name = "Lílian", Salary = 2750.00});
            people.Push(new Person() {Name = "Urbano", Salary = 2000.00});
            
            foreach(var person in people){
                double readjustedSalary = person.readjustSalary();
                person.informSalary(readjustedSalary);
            }
        }
    }
}