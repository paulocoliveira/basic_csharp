using System;

namespace basic_csharp.Collections{
    class UsingArrays{
        public static void Run(){
            String[] students = new String[5];
            students[0] = "Anderson";
            students[1] = "Bia";
            students[2] = "Carlos";
            students[3] = "Daniela";
            students[4] = "Emanuel";

            foreach (var student in students){
                System.Console.WriteLine(student);
            }

            double sum = 0;
            double[] grades = {9.7, 4.8, 8.4, 8.2, 6.8};
            foreach (var grade in grades){
                sum += grade;
            }

            double average = sum / grades.Length;
            System.Console.WriteLine(average);

            char[] letters = {'A', 'r', 'r', 'a', 'y'};
            string word = new string(letters);
            System.Console.WriteLine(word);
        }
    }
}