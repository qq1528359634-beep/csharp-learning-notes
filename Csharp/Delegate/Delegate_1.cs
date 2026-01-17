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
            string[] str = { "赤神", "青神", "かきがみ" };
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
}
