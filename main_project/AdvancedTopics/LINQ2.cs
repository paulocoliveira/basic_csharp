using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_csharp.AdvancedTopics{

    class LINQ2{
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

            var pedro = students.Single(student => student.Name.Equals("Pedro"));
            System.Console.WriteLine($"{pedro.Name} {pedro.Grade}");
            var paulo = students.SingleOrDefault(student => student.Name.Equals("Paulo"));
            if (paulo == null){
                System.Console.WriteLine("Inexistent Student");
            }
            var ana = students.First(student => student.Name.Equals("Ana"));
            System.Console.WriteLine($"{ana.Name} {ana.Grade}");

            var maria = students.FirstOrDefault(student => student.Name.Equals("Maria"));
            if (maria == null){
                System.Console.WriteLine("Inexistent Student");
            }        

            var anotherAna = students.LastOrDefault(student => student.Name.Equals("Ana"));
            System.Console.WriteLine($"{anotherAna.Name} {anotherAna.Grade}");

            var exampleSkip = students.Skip(1).Take(3);
            foreach(var item in exampleSkip){
                System.Console.WriteLine(item.Name);
            }

            var highestGrade = students.Max(student => student.Grade);
            System.Console.WriteLine("Highest Grade: " + highestGrade);

            var lowestGrade = students.Min(student => student.Grade);
            System.Console.WriteLine("Lowest Grade: " + lowestGrade);

            var sumGrade = students.Sum(student => student.Grade);
            System.Console.WriteLine("Sum Grade: " + sumGrade);

            var averageGrade = students.Average(student => student.Grade);
            System.Console.WriteLine("Average Grade: " + averageGrade);

            var averagePassedGrade = students.Where(student => student.Grade > 7).Average(student => student.Grade);
            System.Console.WriteLine("Average Grade of Passed Students: " + averagePassedGrade);
        }
    }
}