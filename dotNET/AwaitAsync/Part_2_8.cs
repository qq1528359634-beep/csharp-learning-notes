using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_8
    {
        async Task Main(string[] args)
        {
            Console.WriteLine("before" + Thread.CurrentThread.ManagedThreadId);
            double r = await CalcAsync(5000);
            Console.WriteLine($"r={r}");
            Console.WriteLine("before" + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task<double> CalcAsync(int x)
        {
            return await Task.Run(() =>
            {
                Console.WriteLine("CalcAsync" + Thread.CurrentThread.ManagedThreadId);
                Random rd = new Random();
                double result = 1;
                for (int i = 0; i < x * x; i++)
                {
                    result += rd.NextDouble();
                }
                return result;
            });

        }
    }
}
