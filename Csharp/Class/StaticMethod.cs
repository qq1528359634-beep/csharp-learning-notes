using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Csharp._01Class
{
    internal class StaticMethod
    {
        private int _number;
        public static int number;
       public  static void MyMethod()
        {
            number = 1;
            Console.WriteLine($"MyMethod is used !{number}");
        }
    }
    class program
    {
        static void Main()
        {
            StaticMethod.MyMethod();  //クラス方法　実例ではなくクラス名で直接訪問  
        }
    }
}
