using System;
using System.Globalization;

namespace basic_csharp.fundamentals{
    class NumberFormat{
        public static void Run(){
            double value = 15.175;
            
            // format with one decimal place
            System.Console.WriteLine(value.ToString("F1"));

            // format as currency 
            System.Console.WriteLine(value.ToString("C"));

            // format as percentual
            System.Console.WriteLine(value.ToString("P"));

            // customized format
            System.Console.WriteLine(value.ToString("#.##"));

            // informing which country you want to define as default culture
            CultureInfo culture = new CultureInfo("en-US");

            // format as currency without decimal place with defined culture
            System.Console.WriteLine(value.ToString("C0", culture));

            // format with specific string size
            int integer = 256;
            System.Console.WriteLine(integer.ToString("D10"));
        }
    }
}