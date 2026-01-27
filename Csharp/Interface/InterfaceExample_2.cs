
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    internal class InterfaceExample_2
    {
        static void Main(string[] args)
        {
            int[] nums = { 999, 7, 8, 18, 19, 20, 21, 22, };
            MyClass[] mies = new MyClass[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                mies[i]= new MyClass();
                mies[i].TheValue = nums[i];
            }
            Program.PrintOut("Initial oder:", mies);
            mies.Sort();
            Program.PrintOut("Sorted oder:", mies);
        }
    }
    class MyClass : IComparable
    {
        public int TheValue;
        //Sort depends on IComparable
        public int CompareTo(object obj)
        {
            MyClass mc = (MyClass)obj;
            if (this.TheValue < mc.TheValue) return -1;
            if (this.TheValue > mc.TheValue) return 1;
            return 0;
        }
    }
    class Program
    {
        public static void PrintOut(string str, MyClass[] mc)
        {
            Console.WriteLine(str);
            foreach (var item in mc)
            {
                Console.WriteLine(item.TheValue);
            }
            Console.WriteLine();
        }
    }

}
