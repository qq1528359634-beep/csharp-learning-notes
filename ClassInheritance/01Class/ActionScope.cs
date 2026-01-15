using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp._01Class
{
    internal class ActionScope
    {
        public string date = "real";

        public string Output()
        {
            string date = "fake";
            return date;
        }
        public string Output_1()
        {
            
            string date = "fake";
            return this.date;
        }
        static void Main(string[] args)
        {
            var s = new ActionScope();
            Console.WriteLine(s.Output());//fake
            Console.WriteLine(s.Output_1());//real
        }
    }
}
