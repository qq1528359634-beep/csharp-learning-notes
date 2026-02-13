using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Part_2_Dependency_Injection
{
    class SqlServerDal : IDateAccess
    {
        public void Add()
        {
            Console.WriteLine("Add a order！");
        }

    }
    class AccessDal : IDateAccess
    {
        public void Add()
        {
            Console.WriteLine("add a data to Access database！ ");
        }
    }
    interface IDateAccess
    {
        void Add();
    }
    class Order
    {
        private readonly IDateAccess _iDA;
        public Order(IDateAccess iDa)
        {
            this._iDA = iDa;
        }
        public void Add()
        {
            _iDA.Add();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IDateAccess, SqlServerDal>();
            services.AddScoped<Order>();
            using (var db = services.BuildServiceProvider())
            {
                Order order = db.GetService<Order>();
                order.Add();
            }
        }
    }
}
