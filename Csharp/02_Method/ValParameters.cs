using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Method_1
{
    internal class ValParameters
    {
        static void Main(string[] args)
        {
            int val = 10;

            ClassParameter cValue = new ClassParameter();
            cValue.Value = 10;

            AddMethod(val, cValue);
            Console.WriteLine($"the value of cValue is {cValue.Value}\n" +
                $"the value of val is {val}");
            //the value of cValue is 20
           // the value of val is 10
        }
        static void AddMethod(int valueParameter, ClassParameter referenceParameter)
        {
            valueParameter += 10;
            referenceParameter.Value += 10;
        }
    }
    class ClassParameter
    {
        public int Value;
    }
}
