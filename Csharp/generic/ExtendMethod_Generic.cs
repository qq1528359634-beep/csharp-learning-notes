using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Csharp.generic
{
    class Holder<T>
    {
        T[] _t = new T[3];
        public Holder(T t1, T t2, T t3)
        {
            _t[0] = t1;
            _t[1] = t2;
            _t[2] = t3;
        }
        public T[] Get()
        {
            return _t;
        }
    }
    static class ExtenHolder
    {
        public static void Print<T>(this Holder<T> t1)
        {//holder　中の_t値を取得
            T[] vlas = t1.Get();
            Console.WriteLine($"First:{vlas[0]} Second:{vlas[1]} Third:{vlas[2]}");
        }
    }
    internal class ExtendMethod_Generic
    {
        static void Main(string[] args)
        {
            var holder = new Holder<int>(99, 99, 77);
            holder.Print();

        }
    }
}
