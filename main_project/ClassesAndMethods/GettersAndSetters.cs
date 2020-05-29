using System;

namespace basic_csharp.ClassesAndMethods{
    
    public class Motorcycle{
        private string Brand;
        private string Model;
        private uint Cc;
        public Motorcycle(string brand, string model, uint cc){
            Brand = brand;
            Model = model;
            Cc = cc;
        }
        public Motorcycle(){

        }

        public string GetBrand(){
            return Brand;
        }

        public void SetBrand(string brand){
            Brand = brand;
        }

        public string GetModel(){
            return Model;
        }

        public void SetModel (string model){
            Model = model;
        }

        public uint GetCc(){
            return Cc;
        }

        public void SetCc(uint cc){
            Cc = cc;
        }
    }
    class GettersAndSetters{
        public static void Run(){
            var motorCycle1 = new Motorcycle("Kawasaki", "Ninja ZX-6R", 636);
            System.Console.WriteLine(motorCycle1.GetBrand());
            System.Console.WriteLine(motorCycle1.GetModel());
            System.Console.WriteLine(motorCycle1.GetCc());
            var motorCycle2 = new Motorcycle();
            motorCycle2.SetBrand("Honda");
            motorCycle2.SetModel("CG Titan");
            motorCycle2.SetCc(150);
            System.Console.WriteLine(motorCycle2.GetBrand() + " " + motorCycle2.GetModel() + " " + motorCycle2.GetCc());

        }
    }
}