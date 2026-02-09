using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{   //デリゲートを宣言する
    delegate void MyDel(int value);
    internal class Programe
    {
        static void Main(string[] args)
        {
            Programe prog = new Programe();
            //MyDelの変数delを最初のメソッドを割り当てる
            MyDel del = new MyDel(prog.GetValue);
            Random rand = new Random();

            int value = rand.Next(1, 100);

            if (value < 50)
            {  //delにメソッドを追加
                del += prog.LowValue;
            } else if (value >= 50)
            {//delにメソッドを追加
                del += prog.HighValue;
            }
            //delに追加されたメソッドを実行する
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
        void GetValue(int value)
        {
            {
                Console.WriteLine($"The value is {value}!");
            }
        }
    } 
}
