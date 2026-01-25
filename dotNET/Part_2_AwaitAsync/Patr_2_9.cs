using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Patr_2_9
    {
        static async Task Main(string[] args)
        {
            string filePat = @"C:\Users\15283\source\repos";
            await File.WriteAllTextAsync(filePat + "\\1.txt", "Hello 1");
            await File.WriteAllTextAsync(filePat + "\\2.txt", "Hello 2");
            var str = await ReadAllAsync(3);
            Console.WriteLine(str);

        }
        /* public static async Task<string> ReadAllAsync(int num)
         {
             switch (num)
             {
                 case 1:
                     return await File.ReadAllTextAsync(@"C:\Users\15283\source\repos\1.txt");
                 case 2:
                     return await File.ReadAllTextAsync(@"C:\Users\15283\source\repos\2.txt");
                 default:
                     throw new ArgumentException("Wrong number");
             }
         }*/
        public static Task<string> ReadAllAsync(int num)
        {
            switch (num)
            {
                case 1:
                    return File.ReadAllTextAsync(@"C:\Users\15283\source\repos\1.txt");
                case 2:
                    return File.ReadAllTextAsync(@"C:\Users\15283\source\repos\2.txt");
                default:
                    throw new ArgumentException("Wrong number");
            }
        }
    }
}
}
