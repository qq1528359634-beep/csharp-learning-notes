using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_13_OtherIssue
    {
        public async Task<int> GetCharsAsync(string file)
        {
            string str = await File.ReadAllTextAsync(file);
            return str.Length;
        }
    }
    interface IGetChars
    {
        //dont need to add async
        Task<int> GetCharsAsync(string file);
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in Test2())
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<string> Test1()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("yzk");
            list.Add("youzack.com");
            return list;
        }
        static IEnumerable<string> Test2()
        {
            yield return "Hello";
            yield return "yzk";
            yield return "youzack.com";
        }
    }
    class Program1
    {
        static async Task Main(string[] args)
        {
            await foreach (var item in Test3())
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<string> Test1()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("yzk");
            list.Add("youzack.com");
            ///string[] strs = { "1", "2" };
            return list;
        }
        //static IEnumerable<string> Test2()
        //{
        //    yield return "Hello";
        //    yield return "yzk";
        //    yield return "youzack.com";
        //}
        static async IAsyncEnumerable<string> Test3()
        {
            yield return "Hello";
            yield return "Hello1";
            yield return "Hello2";
        }

    }
}
