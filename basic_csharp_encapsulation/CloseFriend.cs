using System;

namespace Encapsulation{
    public class CloseFriend : Subcelebrity{
        
        public readonly Subcelebrity friend = new Subcelebrity();
        public new void MyAccesses(){
            System.Console.WriteLine("Close Friend...");
            System.Console.WriteLine(friend.PublicInfo);
            //System.Console.WriteLine(friend.EyesColor);
            System.Console.WriteLine(friend.MobileNumber);
            System.Console.WriteLine(friend.SpeakingWay);
            //System.Console.WriteLine(friend.FamilySecret);
            //System.Console.WriteLine(friend.TooMuchPhotoshop);
        }
    }
}