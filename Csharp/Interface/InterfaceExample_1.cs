using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    interface Info
    {
        string PrintAge();
        string PrintName();
    }
    internal class interfaceExample_1
    {
        static void PrintInfo(Info info)
        {
            Console.WriteLine($"The name is {info.PrintName()}");
            Console.WriteLine($"The age is {info.PrintAge()}");
        }
        static void Main(string[] args)
        {
            /*Info info1 = new CA();
            Info info2 = new CB();
            PrintInfo(info1);
            PrintInfo(info2);*/
            CA cA = new CA();
            CB cB = new CB();
            PrintInfo( cA );
            PrintInfo( cB );
        }

        class CA : Info
        {
            public int PersonAge { get; set; } = 10;
            public string PersonName { get; set; } = "tim";

            public string PrintAge()
            {
                return PersonAge.ToString();
            }
            public string PrintName()
            {
                return PersonName;
            }
        }
        class CB : Info
        {
            public string First { get; set; } = "Tom";
            public string Last { get; set; } = "scha";

            public int Age { get; set; } = 18;

            public string PrintAge()
            {
                return Age.ToString();
            }
            public string PrintName()
            {
                return First + Last;
            }
        }
    }
}
