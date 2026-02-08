using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    public delegate void MyDele<TInput, TResult>(ref TInput inpute);
    internal class Return_of_MulDelegate
    {
        static void Main(string[] ards)
        {
            var re = new Return_of_MulDelegate();

            MyDele<int, int> myDele = re.Add2;
            myDele += re.Add3;
            myDele += re.Multi4;
            int input = 2;
            myDele(ref input);
            //refence type parameter 
            //Value type parameter
        }
        void Add2(ref int a)
        {
            int b = a += 2;
            Console.WriteLine($"{b}");
        }
        void Add3(ref int a)
        {
            int b = a += 3;
            Console.WriteLine($"{b}");
        }
        void Multi4(ref int a)
        {
            int b = a *= 4;
            Console.WriteLine($"{b}");
        }
    }

}
