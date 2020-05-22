using System;

namespace basic_csharp.classesAndMethods{
    class AttributeChallenge{

        int a = 10;

        public static void Run(){
            //Try to access variable a without changing line 6.
            AttributeChallenge atr = new AttributeChallenge();
            System.Console.WriteLine(atr.a);
        }
    }
}
