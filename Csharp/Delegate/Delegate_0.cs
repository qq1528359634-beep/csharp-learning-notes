using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{　　//delegate definition
    //delegate 戻り値の型　デリゲート名（引数の型　引数、）　　　
    delegate void Method(string name);
    //定義されたデリケートと同じ型な方法だけが割り当て可能


    internal class Delegate_0
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
    #region  Examples of custom delegation (no return value)
    delegate void D1();
    class Program
    {
        static void Main(string[] args)
        {
            D1 d1 = F1;
            d1();//I am F1!
            d1 = F2;
            d1();//I am F2!
        }
        static void F1()
        {
            Console.WriteLine("I am F1!");
        }
        static void F2()
        {
            Console.WriteLine("I am F2!");
        }

    }

    #endregion
    #region  Examples of custom delegation (with return value)
    delegate int D2(int a, int b);
    class Program1
    {
        static void Main(string[] args)
        {
            D2 d2 = Add;
            var a = d2(3, 5);
            //a=8;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

    }

    #endregion
}

