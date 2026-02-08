using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    
    class Myclass : IComparable
    {
        public int value;

        public int CompareTo(object other)
        {
            var mc = (Myclass)other;
            if (this.value < mc.value) return -1;
            if (this.value > mc.value) return 1;
            else return 0;
            //return   -this.value.CompareTo(mc.value);
        }


    }
    class Implement_ICompareable
    {
        static void Main(string[] args)
        {
            int[] myInts = new int[] { 5, 3, 8, 1, 4 };
            Myclass[] myclasses = new Myclass[myInts.Length];
            //int[] myInts={5,3,8,1,4};  
            for (int i = 0; i < myInts.Length; i++)
            {
                myclasses[i] = new Myclass();
                myclasses[i].value = myInts[i];
            }
            PrintItems(myclasses);
            myclasses.Sort();
            Console.WriteLine();
            PrintItems(myclasses);
        }
        static void PrintItems(Myclass[] items)
        {
            foreach (var item in items)
            {
                Console.Write(item.value + ",");
            }
        }
    }
}
