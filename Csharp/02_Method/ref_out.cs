using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp._02_Method
{
    internal class ref_out
    {
        static void Main(string[] args)
        {
            
            //out引数は、メソッド内で必ず初期化しなければならない
            //ref引数は、メソッド呼び出し前に初期化しておく必要がある
            int refVal =10;
            //int outVal;
            
            AddMethod(ref refVal, out int outVal);

            void AddMethod(ref int refVal, out int outVal)
            {  
                outVal = 10;
            }

        }
    }
}
