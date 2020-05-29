using System;

namespace basic_csharp.Exceptions{

    public class NegativeException : Exception{
        public NegativeException(){ }

        public NegativeException(string message) : base(message){ }

        public NegativeException(string message, Exception inner) : base(message, inner){ }
    }

    public class OddException : Exception{
        public OddException(string message) : base(message){ }
    }



    class CustomExceptions{
        public static int PositiveEven(){
            Random random = new Random();
            int value = random.Next(-30,30);
            if (value < 0){
                throw new NegativeException("Negative Value!");
            } 
            
            if (value % 2 != 0){
                throw new OddException("Odd Value!");
            } 
            
            return value;
            
        }
        public static void Run(){
            try{
                System.Console.WriteLine(PositiveEven());
            } catch (NegativeException ex){
                System.Console.WriteLine(ex.Message);
            } catch (OddException ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}