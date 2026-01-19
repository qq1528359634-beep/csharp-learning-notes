using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    class Logger
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
      internal  Produce produce {  get; set; }
    }
     class  ProductFactory
    {
        public Produce MakeBall()
        {
            Produce ball = new Produce()
            {
                Name = "Ball"
                ,Price = 10
            };
            return ball;
            
        }
        public Produce MakeToyCar()
        {
            Produce toyCar = new Produce()
            {
                Name = "ToyCar"
                ,Price = 100
                
            };
            return toyCar;  
        }
    }
    class WrapFactory
    {
        public Box WrapProduce(Func<Produce> getProduce,Action<Produce> LogCallBack)
        {
            Produce produce = getProduce();
            if (produce is Produce && produce.Price > 50)
            {
                LogCallBack(produce);
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
            ProductFactory proFactory = new();
            Logger logger = new Logger();
            Box box = new();
            Box box1 = new();
            Func<Produce> getBall=proFactory.MakeBall;
            Func<Produce> getToyCar=proFactory.MakeToyCar;
            Action<Produce>  logCallBack = logger.Log;
            WrapFactory wrapFactory = new WrapFactory();
            box = wrapFactory.WrapProduce(getToyCar, logCallBack);
            box1 = wrapFactory.WrapProduce(getBall, logCallBack);
            Console.WriteLine(box.produce.Name);
            Console.WriteLine(box.produce.Price);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(box1.produce.Name);
            Console.WriteLine(box1.produce.Price);
        }
    }
}
