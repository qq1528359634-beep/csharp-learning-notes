using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    class EventPublisher
    {
        public event EventHandler SomethingHappened;
        public void RaiseEvent()
        {
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }
    class EventSubscriber
    {
        public void OnSomethingHappened_1(object sender, EventArgs e)
        {
            Console.WriteLine("Something happened!");
        }
        public void OnSomethingHappened_2(object sender, EventArgs e)
        {
            Console.WriteLine("remind Something  happened!");
        }
    }


    internal class Remove_EventSubscriber
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            // Subscribe to the event
            publisher.SomethingHappened += subscriber.OnSomethingHappened_1;
            publisher.SomethingHappened += subscriber.OnSomethingHappened_2;

            Console.WriteLine("raised event");
            // Raise the event
            publisher.RaiseEvent();

            // Unsubscribe from the event
            Console.WriteLine("Unsubscribe one of Subscriber from the event");
            publisher.SomethingHappened -= subscriber.OnSomethingHappened_2;

            Console.WriteLine("raised event again");
            // Raise the event again
            publisher.RaiseEvent();
        }
    }
}
