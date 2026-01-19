using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int OutOnenumber()
        {
            return 5;
        }
        public void Print()
        {
            Console.WriteLine("I have five methods");
        }
        public int Get(int a)
        {
            return a;
        }

    }
    internal class SimpleUseOfDelegate
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Action action = cal.Print;
            action();
            Func<int> func = cal.OutOnenumber;
            Console.WriteLine(func());//return 5
            Func<int, int, int> func1 = cal.Add;
            int x = 100, y = 200, z;
            z = func1(x, y);
            Console.WriteLine(z);//300
            func1 = cal.Sub;
            z = func1(x, y);
            Console.WriteLine(z);//-100
            Type type = func1.GetType();
            Console.WriteLine(type.Name);//Func 3
            Console.WriteLine(type.IsClass);//true
            Func<int, int> func2 = cal.Get;
            type = func2.GetType();
            Console.WriteLine(type.Name);//Func 2

        }
    }
}
