using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    class Logger
    {
        public void Log(Produce produce)
        {
            Console.WriteLine($"Produce name is {produce.Name}" +
                $"Product time is{DateTime.UtcNow},Produce price is{produce.Price}");
        }
    }
    class Produce
    {
        public string Name { get; set; }    
        public double Price { get; set; }   
    }
    class Box
    {
        Produce produce {  get; set; }
    }
     class  
    {
        
    }
    internal class NormalUseOfDelegate
    {
    }
}
