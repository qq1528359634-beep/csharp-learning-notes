using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Csharp._01Class
{
    internal class Method
    {
        public void PrintName(string name)
        {  
            Console.WriteLine($"{name}");
            return; //ここでメソッドが終わる
            Console.WriteLine($"Can not be printed");
        }
  
        public void MethodPrint()
        {
            Add(2d);//ローカル関数を宣言位置より前の位置で呼び出す
            double Add( double value )
            {
                var res = 1 + value;
                Console.WriteLine(res);
                return res;
            }
        }
        public void VariablesPrint()
        {
            Console.WriteLine(str);//ローカル変数を宣言位置より前の位置で呼び出せない
            string str = "test";
        }
        public void VariablesConceal()
        {
            string str = "I like you !";
            void PrintTrue()
            {
                string str = "I hate you !";//外のstrはブロック内のstrによって隠蔽された
                Console.WriteLine(str); //I hate you !
            }
        }
        public void VariablesConflict()
        {
            string date ="Local variables";
            {
                string date = "block variables"; //Variables Conflict　error～
            }
        }
    }
}
