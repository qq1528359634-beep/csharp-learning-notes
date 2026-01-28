using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.LINQ
{
    internal class Slove_algorithms_problems
    {
        static void Main(string[] args)
        {
            #region First calculate the average of string
            string str = "61,90,100,99,18,22,38,66,80,93,55,50,89";
            /* double sum = 0;
             int count = 0;
             int current =0;
             for (int i = 0; i <=str.Length; i++)
             {


                 if (i < str.Length && char.IsDigit(str[i]))
                 {
                     current = current * 10 + (str[i] - '0');
                 }
                 else
                 {

                     count++;
                     sum += current;
                     current =0;
                 }

             }
             double ave = sum / count;
             Console.WriteLine(ave);*/
            double b = str.Split(',').Select(e => Convert.ToInt32(e)).Average();
            Console.WriteLine(b);
            #endregion


            string str1 = "hello World,hahah,heiheihei";
          /*  Dictionary<char, int> pairs = new Dictionary<char, int>();
            foreach (var c in str1)
            {
                while (char.IsLetter(c))
                {
                    if (!pairs.ContainsKey(c))
                    {
                        pairs.Add(c, 1);
                    }
                    else if (char.IsLetter(c))
                    {
                        pairs[c]++;

                    }
                    break;
                }
            }
            foreach (var item in pairs)
            {
                if (item.Value > 2)
                {
                    Console.WriteLine(item);
                }

            }*/

           
            var a = str1.Where(e => char.IsLetter(e)).Select(e => char.ToLower(e))
                .GroupBy(e => e).Select(e => new
                {
                    Letter = e.Key,
                    Count = e.Count()
                }).OrderByDescending(e => e.Count).Where(e => e.Count > 2);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


        }
    }

}

