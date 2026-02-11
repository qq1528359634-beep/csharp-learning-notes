using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic
{
    
    delegate void ADelegate<T>(T t1);
    class MyMethods
    {
        public static void Print(string str)
        {
            Console.WriteLine($"{str}");

        }
        public static void ToUpper(string str)
        {
            Console.WriteLine($"{str.ToUpper()}");
        }
    }
    class delegate_generic
    {
        static void Main(string[] args)
        {
            ADelegate<string> aDelegate = MyMethods.Print;
            aDelegate += MyMethods.ToUpper;
            aDelegate("hello");
        }

    }

}
