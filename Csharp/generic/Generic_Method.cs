using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic
{
    internal class Generic_Method
    {
        static void Main(string[] args)
        {  
            int[] ints = new int[3] { 1, 2, 3 };
            string[] strs = new string[3] { "I", "like", "apple" };
            double[] doubles = { 1.2, 2.5, 3.4 };
            Simple simple = new Simple();
            simple.ReverseAndPrint(ints);
            simple.ReverseAndPrint<int>(ints);

            simple.ReverseAndPrint(strs);
            simple.ReverseAndPrint<string>(strs);

            simple.ReverseAndPrint(doubles);
            simple.ReverseAndPrint<double>(doubles);
        }

    }
    class Simple
    {
        public void ReverseAndPrint<T>(T[] values)
        {
            Array.Reverse(values);
            foreach (T value in values)
            {
                Console.Write($"{value},");
            }
            Console.WriteLine();
        }
    }

}
