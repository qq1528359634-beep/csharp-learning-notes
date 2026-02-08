using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    internal class Invoke
    {
        static void Main(string[] args)
        {
            Invoke invoke = new Invoke();
            Action<int> action = invoke.MethodA;
            action += invoke.MethodB;
            action += invoke.MethodC;
            //if action is not null then invoke with 10
            //else return null without exception
            action?.Invoke(10);
        }
        void MethodA(int a)
        {
            Console.WriteLine($"Method A called {a}");
        }
        void MethodB(int a)
        {
            Console.WriteLine($"Method B called {a}");
        }
        void MethodC(int a)
        {
            Console.WriteLine($"Method C called {a}");
        }
    }


}
