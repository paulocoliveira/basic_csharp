using System;

namespace basic_csharp.ObjectOriented{
    public class Car{
        protected readonly int MaxSpeed;
        int CurrentSpeed;
        public Car(int maxSpeed){
            MaxSpeed = maxSpeed;
        }
        protected int ChangeSpeed(int delta){
            int newSpeed = CurrentSpeed + delta;
            if (newSpeed < 0){
                CurrentSpeed = 0;
            } else if (newSpeed > MaxSpeed){
                CurrentSpeed = MaxSpeed;
            } else{
                CurrentSpeed = newSpeed;
            }
            return CurrentSpeed;
        }

        public virtual int SpeedUp(){
            return ChangeSpeed(5);
        }

        public int SlowDown(){
            return ChangeSpeed(-5);
        }
    }

    public class Uno : Car{
        public Uno() : base(200){

        }
    }

    public class Ferrari : Car{
        public Ferrari() : base(350){

        }
        public override int SpeedUp(){
            return ChangeSpeed(15);
        }

        //hides a method from the inherited class
        public new int SlowDown(){
            return ChangeSpeed(-15);
        }
    }


    class Inheritance{
        public static void Run(){
            System.Console.WriteLine("Working with Uno...");
            Uno car1 = new Uno();
            System.Console.WriteLine(car1.SpeedUp());
            System.Console.WriteLine(car1.SpeedUp());
            System.Console.WriteLine(car1.SlowDown());
            System.Console.WriteLine(car1.SlowDown());
            System.Console.WriteLine(car1.SlowDown());

            System.Console.WriteLine("Working with Ferrari...");
            Ferrari car2 = new Ferrari();
            System.Console.WriteLine(car2.SpeedUp());
            System.Console.WriteLine(car2.SpeedUp());
            System.Console.WriteLine(car2.SlowDown());
            System.Console.WriteLine(car2.SlowDown());
            System.Console.WriteLine(car2.SlowDown());

            System.Console.WriteLine("Working with Ferrari as a Car...");
            Car car3 = new Ferrari();
            System.Console.WriteLine(car3.SpeedUp());
            System.Console.WriteLine(car3.SpeedUp());
            System.Console.WriteLine(car3.SlowDown());
            System.Console.WriteLine(car3.SlowDown());
            System.Console.WriteLine(car3.SlowDown());

            System.Console.WriteLine("Working with Uno as a Car...");
            car3 = new Uno(); //polymorphism
            System.Console.WriteLine(car3.SpeedUp());
            System.Console.WriteLine(car3.SpeedUp());
            System.Console.WriteLine(car3.SlowDown());
            System.Console.WriteLine(car3.SlowDown());
            System.Console.WriteLine(car3.SlowDown());
        }
    }
}