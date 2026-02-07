using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Csharp._01Class
{
    class Calculator
    {
        private double a;
        private double b;
        private double c;

        public Calculator(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        internal double Sum()
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {

            Calculator cal = new(1, 2, 3);
            var res = cal.Average();
            Console.WriteLine(res);

        }
    }




    static class ExetensionMethod
    {
        public static double Average(this Calculator cal)
        {
            return cal.Sum() / 3;
        }
    }
}
