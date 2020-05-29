using System;

namespace basic_csharp.ClassesAndMethods{
    class NamedParams{
        public static void FormatDate(int day, int month, int year){
            System.Console.WriteLine("{0:D2}/{1:D2}/{2}", day, month, year);
        }
        public static void Run(){
            FormatDate(month:1, day:6, year:1996);
        }
    }
}