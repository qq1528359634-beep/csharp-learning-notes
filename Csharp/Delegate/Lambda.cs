using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    internal class Lambda
    {
        static void Main(string[] args)
        {
          
            Func<int, int> func2 = delegate (int a)
            {
                return a * a;
            };
            Func<int, int> func1 = (int a) => { return a * a; };
            //lambda_expression
            Func<int, int> func = a => a * a;
            Console.WriteLine(func(5));//5

        }
    }
}
