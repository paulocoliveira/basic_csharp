using System;
using System.Collections.Generic;

namespace basic_csharp.AdvancedTopics{
    class Nullables{
        public static void Run(){
            Nullable<int> number1 = null;
            int? number2 = null;

            if (number1.HasValue){
                System.Console.WriteLine("Number: {0}", number1);
            }else{
                System.Console.WriteLine("Variable does not have value!");
            }

            // if variable has value, fill in with this value, if no, fill in with 1000
            int value = number1 ?? 1000;
            System.Console.WriteLine(value);

            bool? boolean = null;
            bool result = boolean.GetValueOrDefault();
            System.Console.WriteLine(result);

            try{
                int x = number1.Value;
                int y = number2.Value;
                System.Console.WriteLine(x + y);
            }catch (Exception ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}