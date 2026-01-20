
using System.Text;

namespace AwaitAsync1
{

    class Program
    {
        static async Task Main(string[] args)
        {
            /*string filename = @"C:\Users\15283\source\repos\Drafts\temp\1.txt";
            File.WriteAllText(filename, "hello");
            string s = File.ReadAllText(filename);
            Console.WriteLine(s);*/
            string filename = @"C:\Users\15283\source\repos\Drafts\temp\1.txt";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine("hello");
            }
            //如果没有await则下个文件不等他写完就访问 同时2个进程访问一个文件会报错
            await File.WriteAllTextAsync(filename, sb.ToString());
            string s = await File.ReadAllTextAsync(filename);
            Console.WriteLine(s);
            Task<string> t = File.ReadAllTextAsync(filename);
            string a = await t;
        }
    }


}