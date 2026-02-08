using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Event
{
    internal class A_Standard_Event_Example
    {  //Event
        public event  EventHandler CountedADozens;

        //Invoker
        public void Docount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%12==0)
                {
                    CountedADozens(this,null);
                }
            }
        }
    }
    class Dozens_
    {
        public int DozensCount { get; private set; }
        public Dozens_(A_Standard_Event_Example incrementer)
        {
                DozensCount = 0;
            incrementer.CountedADozens += OnCountedDozens;
        }
        //Subscriber
        void OnCountedDozens(object? sender, EventArgs e) //e can be null
        {
            DozensCount++;
            Console.WriteLine($"counted: {DozensCount}");
        }
    }
    class Program_
    {
        static void Main(string[] args)
        {
            var incrementer = new A_Standard_Event_Example();
            Dozens_ dozens = new Dozens_(incrementer);
            incrementer.Docount();
        }
    }
}
