using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    internal class Date : IGetSet
    {
        int privateDate;
        public int Get()
        {
            return privateDate;
        }
        public int Set(int a)
        {
            privateDate = a;
            return privateDate;
        }

    }
    interface IGet
    {
        int Get();
    }
    interface ISet
    {
        int Set(int a);
    }
    interface IGetSet : IGet, ISet
    {

    }
    class Interface_Inheritance
    {
        static void Main(string[] args)
        {
            IGetSet date = new Date();
            date.Set(100);
            var a = date.Get();
            Console.WriteLine(a);
        }

    }
}
