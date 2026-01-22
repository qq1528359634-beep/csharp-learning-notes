using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_5
    {
        async Task Main_(string[] args)
        {
            string url = "https://www.youzack.com";
            string deskFilePath = @"C:\Users\15283\source\repos\filename.txt";
            var numb = await DownloadsWebAsync(url, deskFilePath);
            Console.WriteLine(numb);


        }
        //假如没有异步方法可以调用
        void Main_()
        {
            string deskFilePath = @"C:\Users\15283\source\repos\filename.txt";
            Task<string> t = File.ReadAllTextAsync(deskFilePath);
            //Result 属性でｔの値を取得する
            string str = t.Result;
            Console.WriteLine(str);
            File.WriteAllTextAsync(@"C:\Users\15283\source\repos\1.txt", "str").Wait();

        }

        static async Task<int> DownloadsWebAsync(string url, string destFilePath)
        {

            string body = "";
            using (HttpClient client = new HttpClient())
            { //HttpClient にはIDisposableが付いてる　using でリソース手動回収
                string str = await client.GetStringAsync(url);
                await File.WriteAllTextAsync(destFilePath, str);

                Console.WriteLine(str);
                Console.WriteLine("OK");

            }
            return body.Length;
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(async (obj) =>
            {
                while (true)
                {
                    await File.WriteAllTextAsync(@"C:\Users\15283\source\repos\2.txt", "aaaa");
                }
            });
            Console.Read();
        }
    }
}
