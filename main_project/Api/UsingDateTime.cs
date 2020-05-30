using System;

namespace basic_csharp.Api{
    class UsingDateTime{
        public static void Run(){
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);
            System.Console.WriteLine(dateTime.Day);
            System.Console.WriteLine(dateTime.Month);
            System.Console.WriteLine(dateTime.Year);

            //without hours
            var today = DateTime.Today;
            System.Console.WriteLine(today);

            //with hours
            var currentDay = DateTime.Now;
            System.Console.WriteLine(currentDay);
            System.Console.WriteLine("Hours: " + currentDay.Hour);
            System.Console.WriteLine("Minutes: " + currentDay.Minute);
            System.Console.WriteLine("Seconds: " + currentDay.Second);

            var tomorrow = currentDay.AddDays(1);
            System.Console.WriteLine(tomorrow);

            var yesterday = currentDay.AddDays(-1);
            System.Console.WriteLine(yesterday);

            System.Console.WriteLine(currentDay.ToString("dd"));
            System.Console.WriteLine(currentDay.ToString("d"));
            System.Console.WriteLine(currentDay.ToString("D"));
            System.Console.WriteLine(currentDay.ToString("g"));
            System.Console.WriteLine(currentDay.ToString("G"));
            System.Console.WriteLine(currentDay.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}