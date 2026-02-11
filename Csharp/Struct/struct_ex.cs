using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Struct
{
    struct Sample
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public Sample()
        {
            Name = "default";
            Data = new byte[] { 1, 2, 3 };
        }
        public void PrintName()
        {
            Console.WriteLine($"{Name}");
        }
    }

    internal class struct_ex
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            foreach (var item in sample.Data)
            {
                Console.WriteLine($"{item}");
            }
            //Syntactic sugar
            int[] ints = { 1, 2, 4 };
            sample.PrintName();
        }
    }
}
