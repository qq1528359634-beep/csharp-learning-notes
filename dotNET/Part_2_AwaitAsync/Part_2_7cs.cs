using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_7cs
    {
        async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            string filename = @"C:\Users\15283\source\repos\filename.txt";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                sb.AppendLine("xxxxxxx");
            }
            //调用了类内部的异步方法切换了线程
            await File.WriteAllTextAsync(filename, sb.ToString());
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
