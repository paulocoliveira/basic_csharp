using System;

namespace Encapsulation{
    public class RecognizedSon : Subcelebrity{
        public new void MyAccesses(){
            System.Console.WriteLine("Recognized Son...");
            System.Console.WriteLine(PublicInfo);
            System.Console.WriteLine(EyesColor);
            System.Console.WriteLine(MobileNumber);
            System.Console.WriteLine(SpeakingWay);
            System.Console.WriteLine(FamilySecret);
            //System.Console.WriteLine(TooMuchPhotoshop);
        }
    }
}