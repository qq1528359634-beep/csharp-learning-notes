using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{　　//delegate definition
    //delegate 戻り値の型　デリゲート名（引数の型　引数、）　　　
    delegate void Method(string name);
    //定義されたデリケートと同じ型な方法だけが割り当て可能
  

    internal class Delegate
    {
        static void Run(string str)
        {
            Console.WriteLine($"{str} 走る");
        }
       static void Main(string[] args)
        {
            Method method = new Method(Run);
            method("早く");
        }
    }
   
}

