using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Method
{
    internal class refParameters
    {
        static void Main(string[] args)
        {
            int val = 10;

            ClassParameter cValue = new ClassParameter();
            cValue.Value = 10;

            AddMethod(ref val, ref cValue);
            Console.WriteLine($"the value of cValue is {cValue.Value}\n" +
                $"the value of val is {val}");
            //the value of cValue is 20
            // the value of val is 20
        }
        static void AddMethod(ref int valueParameter, ref ClassParameter referenceParameter)
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

