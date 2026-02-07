using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Method_2
{
    internal class refClass_valClass
    {
        static void Main(string[] args)
        {
            ClassParameter Value = new ClassParameter();
            ClassParameter refValue = new ClassParameter();
            Addmethod(ref refValue, Value);

            Console.WriteLine($"the value of reValue is {refValue.Value} after method call.");//10
            Console.WriteLine($"the value  is {Value.Value} after method call.");//20   
        }
        static void Addmethod(ref ClassParameter refValue, ClassParameter value)
        {
            refValue.Value += 10;
            Console.WriteLine($"the value of reValue is {refValue.Value}.");//20
            //オブジェクトの参照そのまま、新しいオブジェクトに参照する
            refValue = new ClassParameter();
            Console.WriteLine($"the value of reValue  is {refValue.Value} after new.");//10
            Console.WriteLine();
            //コピーしたオブジェクトの参照を新しいオブジェクトに参照する
            value.Value += 10;
            Console.WriteLine($"the value  is {value.Value}.");//20
            value = new ClassParameter();
            Console.WriteLine($"the value  is {value.Value} after new.");//10
        }
    }

    class ClassParameter
    {
        public int Value=10;
    }
}
