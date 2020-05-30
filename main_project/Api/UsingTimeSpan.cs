using System;

namespace basic_csharp.Api{
    class UsingTimeSpan{
        public static void Run(){
            var interval = new TimeSpan(days: 10, hours:20, minutes:30, seconds: 40);

            System.Console.WriteLine(interval);
            System.Console.WriteLine("Minutes: " + interval.Minutes);
            System.Console.WriteLine("interval in Minutes: " + interval.TotalMinutes);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(15);

            var time = end - start;

            System.Console.WriteLine("Duration: " + time);

            System.Console.WriteLine(interval.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine(interval.Subtract(TimeSpan.FromMinutes(8)));

            System.Console.WriteLine("ToString 1: " + interval.ToString("g"));
            System.Console.WriteLine("ToString 2: " + interval.ToString("G"));
            System.Console.WriteLine("ToString 3: " + interval.ToString("c"));

            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}