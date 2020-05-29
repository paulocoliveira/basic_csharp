using System;

namespace basic_csharp.ClassesAndMethods{
    class StructVsClass{
        
        public struct SPoint{
            public int X;
            public int Y;
        }

        public class CPoint{
            public int X;
            public int Y;

        }
        public static void Run(){
            SPoint point1 = new SPoint {X = 1, Y = 3};
            SPoint point1Copy = point1; //assigned by value
            point1.X = 3;
            System.Console.WriteLine("Point 1 X: {0}", point1.X);
            System.Console.WriteLine("Point 1 Copy X: {0}", point1Copy.X);

            CPoint point2 = new CPoint {X = 2, Y = 3};
            CPoint point2Copy = point2; //assigned by reference
            point2.X = 4;
            System.Console.WriteLine("Point 2 X: {0}", point2.X);
            System.Console.WriteLine("Point 2 Copy X: {0}", point2Copy.X);


        }
    }
}