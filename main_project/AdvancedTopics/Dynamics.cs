using System;
using System.Collections.Generic;

namespace basic_csharp.AdvancedTopics{
    class Dynamics{
        public static void Run(){
            dynamic myObject = "test";
            myObject = 3;
            myObject++;
            System.Console.WriteLine(myObject);

            dynamic student = new System.Dynamic.ExpandoObject();
            student.Name = "Maria";
            student.Grade = 8.9;
            student.Age = 24;

            System.Console.WriteLine($"{student.Name} {student.Grade} {student.Age}");
            
        }
    }
}