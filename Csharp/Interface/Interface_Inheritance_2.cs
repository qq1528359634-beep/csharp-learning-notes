using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Csharp.Interface
{

    interface IVehicle
    {
        public void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running!");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running!");
        }
    }
    interface IWeapon
    {
        public void Fire();
    }
    //接口继承
    interface ITank : IWeapon, IVehicle
    {

    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Fire Boom!");
        }
        public void Run()
        {
            Console.WriteLine("Ka ka ka!");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Fire Boom!!");
        }
        public void Run()
        {
            Console.WriteLine("Ka ka ka!!");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Fire Boom!!!");
        }
        public void Run()
        {
            Console.WriteLine("Ka ka ka!!!");
        }
    }
    class Driver
    {
        private readonly IVehicle _tank;
        public Driver(IVehicle tank)
        {
            _tank = tank;
        }
        public void Drive()
        {
            _tank.Run();
        }
    }
    internal class Interface_Inheritance_2
    {
       static  void Main(string[] args)
        {
            /*//反射的基本
            ITank tank = new HeavyTank();
            //获取类型信息
            var t = tank.GetType();
            var ob = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(ob,null);
            runMi.Invoke(ob,null);*/
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ITank, HeavyTank>();
            services.AddScoped<IVehicle, Car>();
            services.AddScoped<IVehicle, Truck>();//覆盖了car
            services.AddScoped<Driver>();
            var sp = services.BuildServiceProvider();
            var tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();
            var driver = sp.GetService<Driver>();
            driver.Drive();
        }
    }
}
