using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace dotNET.LINQ
{
    #region Why  LINQ
    //LINQ make date processing simpler
    #endregion
    internal class Part_2_14_HowLINQWork
    {
         void Main(string[] args)
        {   //using System.Linq
            int[] nums = new int[] { 3, 5, 66, 77, 33, 2, 9, 35 };
            //where 方法遍历集合中的每个元素对于集合中的每个元素都调用
            //a=>a>10 判断是否为true 如果为true 则返回集合之中
            // IEnumerable<int> reslut = nums.Where(a => a > 10);
            // IEnumerable<int> reslut = MyWhere2(nums, a => a > 10);
            var reslut = MyWhere2(nums, a => a > 10);
            foreach (var item in reslut)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> MyWhere1(IEnumerable<int> items, Func<int, bool> f)
        {
            List<int> result = new List<int>();
            foreach (var item in items)
            {
                if (f(item) == true)
                {
                    Console.WriteLine("MyWhere2:" + item);
                    result.Add(item);
                }
            }
            return result;
        }

        //yield return
        static IEnumerable<int> MyWhere2(this IEnumerable<int> items, Func<int, bool> f)
        {
            foreach (var item in items)
            {
                if (f(item) == true)
                {
                    Console.WriteLine("MyWhere2:" + item);
                    yield return item;
                }

            }


        }
    }
}