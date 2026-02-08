using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    delegate void MyDel(int value);
    internal class Programe
    {
        static void Main(string[] args)
        {
            MyDel del;
            Random rand = new Random();

            Programe prog = new Programe();

            int value = rand.Next(1, 100);
            del = value < 50 ? new MyDel(prog.LowValue) : new MyDel(prog.HighValue);
            del(value);

        }
        void LowValue(int value)
        {
            Console.WriteLine($"{value} is low!");
        }
        void HighValue(int value)
        {
            Console.WriteLine($"{value} is high!");
        }
    } 
}
