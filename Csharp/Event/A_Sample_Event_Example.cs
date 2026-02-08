using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Event
{  //Delegate
    delegate void Handler(string message);
    internal class Incrementer
    {  //Event
        public event Handler CountedADozens;

        //Invoker
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%12==0)
                {               //EventArgs
                    CountedADozens("counted");
                }
            }
        }
    }
    class Dozens
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer evevnt)
        {
                DozensCount = 0;
            evevnt.CountedADozens += OnCountedDozens;
        }

        //Subscriber
        void OnCountedDozens(string message)
        {
            DozensCount++;
            Console.WriteLine($"{message}: {DozensCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var incrementer = new Incrementer();
            Dozens dozens = new Dozens(incrementer);
            incrementer.DoCount();
        }

    }
}
