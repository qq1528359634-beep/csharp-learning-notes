using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_10_Task
    {
        async Task Main(string[] args)
        {
            string url = "https://www.youzack.com";
            string web = await PrintWeb(url);
            Console.WriteLine(web.Substring(0, 100));
        }

        public static async Task<string> PrintWeb(string url)
        {
            string web;
            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < 4; i++)
                {
                    web = await client.GetStringAsync(url);
                    if (!string.IsNullOrEmpty(web))
                    {
                        return web;
                    }
                    else if (i == 3)
                    {
                        Task.Delay(500);
                    }

                }
                throw new ArgumentException("the request is filed !");

            }
        }
    }
}
