using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    internal class Program
    {
         void Main(string[] args)
        {
            Engine engine = new();
            Car car = new(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
        class Engine
        {
            public int PRM { get; private set; }
            public void Work(int gas)
            {
                this.PRM = 1000 * gas;
            }
        }
        class Car
        { //car紧耦合于Engine 
          //当被依赖类出现问题 Car也出问题 
            private Engine _engine;
            public Car(Engine engine)
            {
                _engine = engine;
            }
            public int Speed { get; private set; }

            public void Run(int gas)
            {
                _engine.Work(gas);
                this.Speed = _engine.PRM / 100;
            }
        }

    }
}
