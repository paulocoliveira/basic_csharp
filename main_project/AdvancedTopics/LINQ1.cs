using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_csharp.AdvancedTopics{
    public class Student{
        public string Name;
        public int Age;
        public double Grade;
    }

    class LINQ1{
        public static void Run(){
            var students = new List<Student>{
                new Student() {Name = "Pedro", Age = 24, Grade = 8.0},
                new Student() {Name = "André", Age = 21, Grade = 4.3},
                new Student() {Name = "Ana", Age = 25, Grade = 9.5},
                new Student() {Name = "Jorge", Age = 20, Grade = 8.5},
                new Student() {Name = "Ana", Age = 21, Grade = 7.7},
                new Student() {Name = "Júlia", Age = 22, Grade = 7.5},
                new Student() {Name = "Márcio", Age = 18, Grade = 6.8}
            };

            System.Console.WriteLine("===== Passed =====");
            var passed = students.Where(a => a.Grade > 7).OrderBy(a => -a.Grade);
            foreach (var student in passed){
                System.Console.WriteLine(student.Name);
            }

            System.Console.WriteLine("\n\n===== Presence List =====");
            var list = students.OrderBy(a => a.Name).Select(a => a.Name);
            foreach(var student in list){
                System.Console.WriteLine(student);
            }

            System.Console.WriteLine("\n\n===== Passed by Age =====");
            var passedStudents = 
                from student in students
                where student.Grade >= 7
                orderby student.Age
                select student.Name;
            
            foreach(var student in passedStudents){
                System.Console.WriteLine(student);
            }



        }
    }
}