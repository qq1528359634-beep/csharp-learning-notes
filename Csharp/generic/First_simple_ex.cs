using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic
{
    class GenericClass<T1, T2>
    {
        public T1 SomeVar { get; set; }
        public T2 SomeVar2 { get; set; }

        public GenericClass(T1 t1,T2 t2)
        {
            this.SomeVar = t1;
            this.SomeVar2 = t2;
        }
    }

    internal class First_simple_ex
    {
        static void Main(string[] args)
        {
            var firstGen = new GenericClass<string, int>("like", 4);
            var secondGen = new GenericClass<int, string>(6, "unlike");
           
        }
    }
}
