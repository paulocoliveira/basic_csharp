using System;
using Encapsulation;

namespace basic_csharp.ObjectOriented{
    
    public class NotRecognizedSon : Subcelebrity{
        public new void MyAccesses(){
            System.Console.WriteLine("Not Recognized Son...");
            System.Console.WriteLine(PublicInfo);
            System.Console.WriteLine(EyesColor);
            //System.Console.WriteLine(MobileNumber);
            System.Console.WriteLine(SpeakingWay);
            //System.Console.WriteLine(FamilySecret);
            //System.Console.WriteLine(TooMuchPhotoshop);
        }
    }

    public class NotCloseFriend{
        
        public readonly Subcelebrity friend = new Subcelebrity();
        public void MyAccesses(){
            System.Console.WriteLine("Not Close Friend...");
            System.Console.WriteLine(friend.PublicInfo);
            //System.Console.WriteLine(friend.EyesColor);
            //System.Console.WriteLine(friend.MobileNumber);
            //System.Console.WriteLine(friend.SpeakingWay);
            //System.Console.WriteLine(friend.FamilySecret);
            //System.Console.WriteLine(friend.TooMuchPhotoshop);
        }
    }

    class Encapsulation{
        public static void Run(){
            new Subcelebrity().MyAccesses();
            new RecognizedSon().MyAccesses();
            new CloseFriend().MyAccesses();
            new NotRecognizedSon().MyAccesses();
            new NotCloseFriend().MyAccesses();
        }
    }
}