using System;
using System.Collections.Generic;

namespace basic_csharp.ObjectOriented{
    public abstract class MobilePhone{
        public abstract string Assistant();
        public string Ring(){
            return "Trim, Trim, Trim...";
        }
    }

    public class Samsung : MobilePhone{
        public override string Assistant(){
            return "Hi! My name is Bixby!";
        }
    }

    public class Iphone : MobilePhone{
        public override string Assistant(){
            return "Hi! My name is Siri!";
        }
    }

    class AbstractClass{
        public static void Run(){
            var mobiles = new List<MobilePhone>{
                new Iphone(),
                new Samsung()
            };

            foreach(var mobile in mobiles){
                System.Console.WriteLine(mobile.Assistant());
            }
        }
    }
}