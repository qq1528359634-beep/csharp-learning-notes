using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using Microsoft.Extensions.DependencyInjection;

namespace dotNET.Part_2_Dependency_Injection
{
    internal class Part_2_14_dotNET_DI
    {
        //use DI
        static void Main(string[] args)
        {   //创建存放服务的一个集合
            ServiceCollection services = new ServiceCollection();
            //向其中添加一个服务 
            services.AddTransient<TestServiceImpl>();
            //相当于服务定位器
            using(ServiceProvider sp=services.BuildServiceProvider())
            {   //向服务定位器要一个服务
                TestServiceImpl t= sp.GetService<TestServiceImpl>();
                t.Name = "Test";
                t.SayHi();
            }
        }
    }


    //if do not use DI 
   /*  ITestService t = new TestServiceImpl();
            t.Name = "tom";
            t.SayHi();
*/
    public interface ITestService
    {
        public void SayHi();
        string Name { get; set; }
    }
    public class TestServiceImpl : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"Hi My name is {Name}");
        }
    }
    public class TestServiceImpl2 : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"你好，我是 {Name}");
        }
    }


}
