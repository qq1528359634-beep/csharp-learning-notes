using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace dotNET.Part_2_Dependency_Injection
{
    internal class Part_2_28_dotNET_DI_Infect
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<Controller>();
            services.AddScoped<ILog, LogImpl>();
            //services.AddScoped<IConfig, ConfigImpl>();
            services.AddScoped<IConfig, DBconfigImpl>();
            services.AddScoped<IStorage, StorageImpl>();
            using (var sp = services.BuildServiceProvider())
            {
                var controller = sp.GetRequiredService<Controller>();
                controller.Test();
            }
        }
    }
    class Controller
    {
        private readonly ILog log;
        private readonly IStorage storage;
        public Controller(ILog log, IStorage storage)
        {
            this.log = log;
            this.storage = storage;
        }
        public void Test()
        {
            log.Log("Upload start  ");
            storage.Save("Hello World", "file.txt");
            log.Log("Save completed");
        }
    }
    interface ILog
    {
        public void Log(string msg);
    }
    class LogImpl : ILog
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Log:{msg}");
        }
    }
    interface IConfig
    {
        public string GetValue(string name);
    }
    class ConfigImpl : IConfig
    {
        public string GetValue(string name)
        {
            return "ConfigValue";
        }
    }
    //Reduce coupling between modules
    class DBconfigImpl : IConfig
    {
        public string GetValue(string name)
        {
            return "DBconfigValue";
        }
    }
    interface IStorage
    {
        public void Save(string content, string name);
    }
    class StorageImpl : IStorage
    {
        private readonly IConfig config;
        public StorageImpl(IConfig config)
        {
            this.config = config;
        }
        public void Save(string content, string name)
        {
            string server = config.GetValue("Server");
            Console.WriteLine($"Save {content} to {name} on server {server}");
        }
    }
}


