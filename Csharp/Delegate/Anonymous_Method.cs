using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    public delegate TResult Adel<TInput, TResult>(TInput a); 
    internal class Anonymous_Method
    {
        static void Main(string[] args)
        {
            //anonymous_method
            Adel<int, int> adel = delegate (int a)
            {
                return a * a;
            };
            int result = adel(5);
            Console.WriteLine(result); //output 25
        }

    }
}
