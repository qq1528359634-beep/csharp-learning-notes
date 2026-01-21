using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Csharp.Event
{
    internal class Event_0
    {
        static void Main(string[] args)
        {   //event Source 事件的拥有者
            System.Timers.Timer timer = new();
            timer.Interval = 1000;
            //事件的响应者
            Boy boy = new Boy();
            Girl girl = new Girl();
            //事件  订阅   事件处理器
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();

        }
    }
    class Boy
    {
        internal void Action(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump !");
        }
    }
    class Girl
    {
        internal void Action(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing !");
        }
    }

}

