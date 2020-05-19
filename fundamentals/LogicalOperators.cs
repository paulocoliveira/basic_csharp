using System;

namespace basic_csharp.fundamentals{
    class LogicalOperators{
        public static void Run(){
            
            // if work1 AND work 2 was done, a 50 inch tv will be bought
            var work1Done = true;
            var work2Done = false;

            var tv50Bought = work1Done && work2Done;
            System.Console.WriteLine("Will the 50 inch TV be bought? {0}", tv50Bought);

            // if work1 OR work 2 was done, an ice cream will be bought
            var iceCreamBought = work1Done || work2Done;
            System.Console.WriteLine("Will the ice cream be bought? {0}", iceCreamBought);

            // if just work1 OR just work 2 was done, a32 inch TV will be bought
            var tv32Bought = work1Done ^ work2Done;
            System.Console.WriteLine("Will the 32 inch TV be bought? {0}", tv32Bought);

            // if an ice cream was bought the family is not healthy
            System.Console.WriteLine("Is the family healthy? {0}", !iceCreamBought);

        }
    }
}