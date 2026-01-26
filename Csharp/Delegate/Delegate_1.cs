using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    internal class Delegate_1
    {
        public delegate void OutputPross(string str);

        public void Action(string[] str, OutputPross outputPross)
        {
            foreach (var item in str)
            {
                outputPross(item);
            }

        }

        public static void Main(string[] args)
        {
            Delegate_1 delegate_1 = new Delegate_1();
            Actions actions = new Actions();
            string[] str = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            OutputPross outputPross = new OutputPross(actions.Count);
            outputPross = new OutputPross(actions.Joint);
            Console.WriteLine(actions.CountResult);
            Console.WriteLine(actions.JointResult);
        }

    }
    class Actions
    {
        public string JointResult { get; private set; }
        public int CountResult { get; private set; }
        public void Joint(string str)
        {


            JointResult += str;

        }
        public void Count(string str)
        {

            CountResult += str.Length;

        }
    }
    #region Anonymous delegation 
    class Sample
    {
        static void Main(string[] args)
        {
            Action f1=delegate() { Console.WriteLine("a"); };
            f1();
            Action f11 =  () =>Console.WriteLine("f11");
            f11();
            Func<int, int, string> f12 = (a,b) => $"{a}+{b}={a+b}";

            Action<string,int> f2=delegate(string a,int b) 
            { Console.WriteLine($"a={a},b={b}"); };
            f2("yzk", 18);
            Func<int, int, int> f3 = delegate (int a, int b)
            {
                return a*b;
            };
            Console.WriteLine(f3(5, 8));//40
            //lambda
            //=> goes to
            Func<int, int, int> f4 = (int a, int b)=>
            {
                return a * b;
            };
            Console.WriteLine(f3(5, 8));//40

            //Func<int, int, int> f5 = (a,  b) => a * b;
            Func<int, int, int> f5 = ( a,  b) =>
            {
                return a * b;
            };
            Console.WriteLine(f4(5, 8));//40

            //if noly one parameters () can be omit
            Action<int> f6 = a => Console.WriteLine(a);

            Func<int, bool> f7 = delegate (int a)
            {
                return a > 5;
            };
            Func<int, bool> f8 =  a=>a > 5;
           

        }
    }
    #endregion
}
 