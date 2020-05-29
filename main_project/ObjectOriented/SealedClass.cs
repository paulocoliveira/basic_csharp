using System;

namespace basic_csharp.ObjectOriented{
    sealed class WithoutSon{
        public double FortuneValue(){
            return 1_407_033.65;
        }
    }

    class GrandFather{
        public virtual bool HonorFamilyName(){
            return true;
        }
    }

    class Father : GrandFather{
        public override sealed bool HonorFamilyName(){
            return true;
        }
    }

    class RebelSon : Father{
        // cannot override because father has a sealed method
        // public override bool HonorFamilyName(){
        //     return false;
        // }
    }


    class SealedClass{
        public static void Run(){
            WithoutSon withoutSon = new WithoutSon();
            Console.WriteLine(withoutSon.FortuneValue());
            RebelSon RebelSon = new RebelSon();
            Console.WriteLine(RebelSon.HonorFamilyName());
        }
    }
}