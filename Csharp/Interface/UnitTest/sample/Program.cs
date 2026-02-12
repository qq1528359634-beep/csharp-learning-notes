using System;
using System.Collections;

namespace ASample
{
    class Program
    {

         void Main(string[] args)
        {
            int[] nums = new int[]{ 1, 2, 3, 4, 5 };
            List<int> nums2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(nums));
            Console.WriteLine(Average(nums));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Average(nums2));

        }
        //要求传进来的对象能够被迭代
        static int Sum(IEnumerable nums)
        {   int sum = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
            }
            return sum;
        }
        static double Average(IEnumerable nums)
        {
            int sum = 0; double count = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
                count++;
            }
            return sum/ count;
        }
      
    }


}