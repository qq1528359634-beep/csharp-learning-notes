using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_4
    {
       static async Task Main(string[] args)
        {
            // string filename = @"C:\Users\15283\source\repos\file.txt";
            // File.WriteAllText(filename,"Hello World !");
            //string str= File.ReadAllText(filename);
            // Console.WriteLine(str);
            string filename = @"C:\Users\15283\source\repos\file.txt";
            await File.WriteAllTextAsync(filename, "Hello World");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.AppendLine("Hello");
            }
            await File.WriteAllTextAsync(filename, sb.ToString());
            string str = await File.ReadAllTextAsync(filename);
            //Task<string> str =  File.ReadAllTextAsync(filename);
            //string str2 = await str;
            Console.WriteLine();
        }
    }
}
