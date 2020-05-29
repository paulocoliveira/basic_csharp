using System;

namespace basic_csharp.Fundamentals{
    class Comments{
        public static void Run(){

            //Take care with unnecessary comment
            Console.WriteLine("Clear code is always better!");

            /// <sumary>
            /// Documentation
            /// </summary>            
            Console.WriteLine("C# has XML comments.");

            /*
             * Block comments
             * has multiple lines.
            */

            Console.WriteLine("C# has block comments.");
        }
    }

}