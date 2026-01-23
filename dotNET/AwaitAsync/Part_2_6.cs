using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_6
    {
        async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://www.taobao.com";
                string content = await client.GetStringAsync(url);
                Console.WriteLine(content);
            }
            string filename = @"C:\Users\15283\source\repos\3.txt";
            await File.WriteAllTextAsync(filename, "aaaaa");
            string res = await File.ReadAllTextAsync(filename);
            Console.WriteLine(res);

        }
    }
}
