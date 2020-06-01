using System;
using System.Collections.Generic;
using basic_csharp.Exercises.Challenge.Models;
using System.IO;
using System.Linq;

namespace basic_csharp.Exercises.Challenge{

    class ChallengeExercise{
        /*
        * Read a txt file containing a list of people. Convert people from file to an Person object list.
        * Select people that are coordinators and that have salary greater than 100 (LINQ). Show name, rola
        * and salary of this selection.
        */
        public static void Run(){
            var currentDir = Directory.GetCurrentDirectory();
            var path = $"{currentDir}\\Exercises\\Challenge\\Files\\people.txt";
            try{
                using (StreamReader sr = new StreamReader(path)){
                    var people = new List<Person>();
                    String line;
                    while((line = sr.ReadLine()) != null){ 
                        String[] data = line.Split(";");
                        people.Add(new Person(data[0], data[1], Convert.ToDouble(data[2])));
                    }

                    var coordinatorsMoreThan100 = 
                        from person in people
                        where person.Role.Equals("Coordinator") && person.Salary > 100
                        select person;
                    
                    foreach(Person coordinator in coordinatorsMoreThan100){
                        coordinator.informSalary();
                    }
                }
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}