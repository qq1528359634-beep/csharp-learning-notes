using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Event
{
    internal class useEventArgs : EventArgs
    {
        public string DozenNumber { get; set; }
    }
    class CountDozens
    {
        public event EventHandler<string> CountedADozens;
        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 12 == 0)
                {
                    useEventArgs args = new useEventArgs();
                    args.DozenNumber = $"dozens: {i}";
                    CountedADozens?.Invoke(this, args.DozenNumber);
                }
            }
        }
    }
    class DozenSubscriber
    {
        public int DozensCounted { get; set; }
        public DozenSubscriber(CountDozens cD)
        {
            cD.CountedADozens += OnCounteredDozens;
        }
        public void OnCounteredDozens(object? sender, string e)
        {
            Console.WriteLine(e + $" total of dozen number is {DozensCounted}");
            DozensCounted++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CountDozens cD = new CountDozens();
            DozenSubscriber dS = new DozenSubscriber(cD);
            cD.DoCount();
        }
    }

}
