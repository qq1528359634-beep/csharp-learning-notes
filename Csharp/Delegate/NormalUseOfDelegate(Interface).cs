using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate1
{
    interface IProduceFactory
    {
        public Produce Make();
    }
    interface ILog
    {
        public void Log(Produce produce);
    }
    class Logger : ILog
    {
        public void Log(Produce produce)
        {
            Console.WriteLine($" Produce name is {produce.Name}" +
                $"Product time is {DateTime.UtcNow},Produce price is {produce.Price}");
        }
    }
    class Produce
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        internal Produce produce { get; set; }
    }
    class BallFactory : IProduceFactory
    {
        public Produce Make()
        {
            Produce ball = new Produce()
            {
                Name = "Ball"
                ,
                Price = 10
            };
            return ball;

        }

    }
    class ToyFactory : IProduceFactory
    {
        public Produce Make()
        {
            Produce toyCar = new Produce()
            {
                Name = "ToyCar"
                ,
                Price = 100

            };
            return toyCar;
        }

    }
    class WrapFactory
    {
        public Box WrapProduce(IProduceFactory getProduce, ILog log)
        {
            Produce produce = getProduce.Make();
            if (produce is Produce && produce.Price > 50)
            {
                log.Log(produce);
            }
            Box box = new Box();
            box.produce = produce;
            return box;
        }

    }
    internal class NormalUseOfDelegate
    {
        static void Main(string[] args)
        {
            Box box = new();
            WrapFactory wrapFactory = new WrapFactory();
            IProduceFactory produceFactory = new ToyFactory();
            IProduceFactory produceFactory1 = new BallFactory();
            ILog log = new Logger();
            box = wrapFactory.WrapProduce(produceFactory, log);
            Console.WriteLine(box.produce.Name);
            Console.WriteLine(box.produce.Price);

        }
    }
}
