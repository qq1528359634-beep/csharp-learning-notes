using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Conversion
{
    internal class checked_unchecked
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int b = 0;
            short s;
            s = checked((short)b);
            Console.WriteLine(s);
            s = unchecked((short)a);//ignore overflow 
            Console.WriteLine(s);
            s = checked((short)a);//checked:if overflow throw exception
            Console.WriteLine(s);

            checked
            {
                //if have any  overflow in block throw exception
                unchecked
                {
                    //..........
                }
            }
            

        }
    }
}
