using System;

namespace basic_csharp.MethodsAndFunctions{
    delegate string StringOperation(string s);

    class DelegateAnonymousFunction{
        public static void Run(){
            StringOperation invert = delegate (string s){
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            System.Console.WriteLine(invert("C# is amazing!"));
        }
    }
}