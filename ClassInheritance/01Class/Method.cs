using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Csharp._01Class
{
    internal class Method
    {
        public void PrintName(string name)
        {  
            Console.WriteLine($"{name}");
            return; //ここでメソッドが終わる
            Console.WriteLine($"Can not be printed");
        }
     
        public void PrintType()
        {
            Add(2d);
            double Add( double value )
            {
                var res = 1 + value;
                Console.WriteLine(res);
                return res;
            }
        }
    }
}
