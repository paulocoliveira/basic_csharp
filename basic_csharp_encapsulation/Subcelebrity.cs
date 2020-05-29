using System;

namespace Encapsulation{
    public class Subcelebrity{
        //All
        public string PublicInfo = "I have an Instagram account!";

        //Inheritance
        protected string EyesColor = "Green";

        //Same project (assembly)
        internal ulong MobileNumber = 5581999999999;

        //Inheritance or same project
        protected internal string SpeakingWay = "Lot of jargon!";

        //Same class or inheritance in the same project
        private protected string FamilySecret = "Bla bla bla!";

        //private as default, only inside this class
        bool TooMuchPhotoshop = true;

        public void MyAccesses(){
            System.Console.WriteLine("Subcelebrities...");
            System.Console.WriteLine(PublicInfo);
            System.Console.WriteLine(EyesColor);
            System.Console.WriteLine(MobileNumber);
            System.Console.WriteLine(SpeakingWay);
            System.Console.WriteLine(FamilySecret);
            System.Console.WriteLine(TooMuchPhotoshop);
        }
        
    }
}
