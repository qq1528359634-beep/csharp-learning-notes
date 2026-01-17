using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.MemberModifiers
{
    internal class Readonly
    {
        public static readonly  int[] values={1,2,3};
       
        public Readonly()
        {
            //values = new[] { 10, 20, 30 };//エラー
            values[0] = 10;
        }
    }
}
