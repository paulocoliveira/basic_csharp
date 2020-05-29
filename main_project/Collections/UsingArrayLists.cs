using System;
using System.Collections;

namespace basic_csharp.Collections{
    class  UsingArrayLists{
        public static void Run(){
            var arrayList = new ArrayList{
                "Word",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList){
                System.Console.WriteLine("{0} => {1}", item, item.GetType());
            }

        }
    }
}