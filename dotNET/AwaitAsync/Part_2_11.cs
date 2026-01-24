using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.AwaitAsync
{
    internal class Part_2_11
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new();
            //cts.CancelAfter(3000);
            CancellationToken cToken = cts.Token;
            DownLoad3Async(100, cToken);
            while (Console.ReadLine() != "q")
            {

            }
            cts.Cancel();
            Console.ReadLine();

        }
        #region method
        public static async Task DownLoadAsync(int n, CancellationToken cancellationToken)
        {
            string url = "https://www.youzack.com";
            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < n * n; i++)
                {
                    string web = await client.GetStringAsync(url);
                    Console.WriteLine($"{DateTime.Now},{web}");
                    //如果请求速度特别慢（1分钟）那么不会在5秒钟就
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("request is be canceled !");
                        break;
                    }
                    //cancellationToken.ThrowIfCancellationRequested();


                }


            }

        }
        #endregion
        #region method2
        public static async Task DownLoad2Async(int n, CancellationToken cancellationToken)
        {
            string url = "https://www.youzack.com";
            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < n * n; i++)
                {   //如果请求速度特别慢（1分钟）那么不会在5秒钟就
                    string web = await client.GetStringAsync(url);
                    Console.WriteLine($"{DateTime.Now},{web}");
                    //检测到请求被取消 直接抛出异常终止
                    cancellationToken.ThrowIfCancellationRequested();


                }


            }

        }
        #endregion
        public static async Task DownLoad3Async(int n, CancellationToken cancellationToken)
        {
            string url = "https://www.youzack.com";
            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < n * n; i++)
                {
                    var resp = await client.GetAsync(url);
                    string html = await resp.Content.ReadAsStringAsync();
                    Console.WriteLine($"{DateTime.Now}:{html}");
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("request is be canceled !");
                        break;
                    }
                }


            }

        }
    }
}
