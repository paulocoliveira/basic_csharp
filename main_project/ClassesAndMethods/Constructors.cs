using System;

namespace basic_csharp.ClassesAndMethods{
    class Car{
        public string Brand;
        public string Model;
        public int Year;

        public Car(){
        }
        public Car(string brand, string model, int year){
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
    class Constructors{
        public static void Run(){
            var car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "325i";
            car1.Year = 2021;
            System.Console.WriteLine($"{car1.Brand} {car1.Model} {car1.Year}");

            var car2 = new Car("Ford", "Ka", 2018);
            System.Console.WriteLine($"{car2.Brand} {car2.Model} {car2.Year}");

            var car3 = new Car(){
                Brand = "Fiat",
                Model = "Uno",
                Year = 2020
            };

            System.Console.WriteLine($"{car3.Brand} {car3.Model} {car3.Year}");
        }
    }
}