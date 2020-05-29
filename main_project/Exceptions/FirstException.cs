using System;

namespace basic_csharp.Exceptions{
    
    public class Account{
        double Balance;

        public Account(double balance){
            Balance = balance;
        }

        public void Withdraw(double value){
            if (value > Balance){
                throw new ArgumentException("Insufficient Balance!");
            }
            Balance -=  value;
        }
    }
    class FirstException{
        public static void Run(){
            var account = new Account(1_223.45);
            try{
                account.Withdraw(1600);
                System.Console.WriteLine("Success!");
            } catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            } finally{
                System.Console.WriteLine("Thanks!!!");
            }
        }
    }
}