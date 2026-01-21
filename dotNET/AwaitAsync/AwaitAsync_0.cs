using System.Text;

namespace dotNET.AwaitAsync
{

    class Program
    {
        static async Task Main(string[] args)
        {   //filenameにファイルアドレスとファイルタイトルを与える
            /* string filename = @"C:\Users\15283\source\repos\file.txt";
             File.WriteAllText(filename, "hello");
            string str= File.ReadAllText(filename);
             Console.WriteLine(str);*/
            string filename = @"C:\Users\15283\Source\repos\file.txt";
            await File.WriteAllTextAsync(filename, "hello");
            string str = await File.ReadAllTextAsync(filename);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine("hello");
            }
            await File.WriteAllTextAsync(filename, sb.ToString());
            //awaitが自動的にTask中の戻り値を取ってくれる
            //イコール下のコード　
            Task<string> t = File.ReadAllTextAsync(filename);
            str = await t;

            Console.WriteLine(str);

        }
    }


}