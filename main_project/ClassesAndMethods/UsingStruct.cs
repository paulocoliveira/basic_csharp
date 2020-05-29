using System;

namespace basic_csharp.ClassesAndMethods{
    
    interface Point{
        void MoveDiagonally(int delta);
    }
    struct Coordinate: Point{
        public int X;
        public int Y;
        public Coordinate(int x, int y){
            X = x;
            Y = y;
        }
        public void MoveDiagonally(int delta){
            X += delta;
            Y += delta;
        }
    }
    class UsingStruct{
        public static void Run(){
            Coordinate coordinate1;
            coordinate1.X = 2;
            coordinate1.Y = 2;
            System.Console.WriteLine("Coordinate 1: x = {0}, y = {1}", coordinate1.X, coordinate1.Y);
            var coordinate2 = new Coordinate(x: 9, y: 1);
            coordinate2.MoveDiagonally(10);
            System.Console.WriteLine("Coordinate 2: x = {0}, y = {1}", coordinate2.X, coordinate2.Y);
        }
    }
}