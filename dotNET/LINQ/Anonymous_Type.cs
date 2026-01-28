using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.LINQ
{
    internal class Anonymous_Type
    {
       static void Main(string[] args)
        {
            var a = new { Name = "AAA", Age = 10 };
            Console.WriteLine(a.Name);
            Console.WriteLine(a.Age);
        }
    }
}
