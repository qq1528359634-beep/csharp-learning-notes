using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using Microsoft.Extensions.DependencyInjection;

namespace dotNET.Part_2_Dependency_Injection
{
    internal class Part_2_25_dotNET_DI
    {
        //use DI

        static void Main(string[] args)
        {
            //创建存放服务的一个集合
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ITestService, TestServiceImpl>();
            services.AddScoped<ITestService, TestServiceImpl2>();
            //service.AddScoped<typeof(ITestService), typeof(TestServiceImpl)>;
            //service.AddScoped<typeof(ITestService), new TestServiceImpl()>;
            //service.AddScoped<TestServiceImpl,  TestServiceImpl()>;
            using (ServiceProvider sp = services.BuildServiceProvider())
            {   //我只要求服务   框架负责帮我现实
                //if GetService not find service,return null
                //ITestService ts1 = sp.GetService<TestServiceImpl>();
                ITestService ts1 = sp.GetService<ITestService>();
                ts1.Name = "tom";
                ts1.SayHi();
                Console.WriteLine(ts1.GetType());
                //if GetRequiredService not find service,throw exception
                ITestService ts2 = sp.GetRequiredService<ITestService>();
                //get services
                IEnumerable<ITestService> tests =sp.GetServices<ITestService>();
                foreach (ITestService test in tests)
                {
                    Console.WriteLine(test.GetType());
                }
                //when add many services of the same interface,GetService
                //or GetRequiredService will return the last one
                var tests1 = sp.GetService<ITestService>();
                foreach (ITestService test in tests)
                {
                    Console.WriteLine(test.GetType());
                }
            }
        }   


        #region AddTransient
        static void Main_1(string[] args)
        {   //创建存放服务的一个集合
            ServiceCollection services = new ServiceCollection();
            //向其中添加一个服务 
            
            services.AddTransient<TestServiceImpl>();
            //相当于服务定位器
            using(ServiceProvider sp=services.BuildServiceProvider())
            {   //向服务定位器要一个服务
                TestServiceImpl t= sp.GetService<TestServiceImpl>();
                t.Name = "tom";
                t.SayHi();

                TestServiceImpl t1 = sp.GetService<TestServiceImpl>();
                t1.Name = "tim";
                t1.SayHi();
                //t1　t2は同じ対象ですか
                object.ReferenceEquals(t1, t);//false 同じ対象ではありません
                t.SayHi();//tim
            }
            #endregion

            #region AddSingleton

            services.AddSingleton<TestServiceImpl>();
            //相当于服务定位器
            using (ServiceProvider sp = services.BuildServiceProvider())
            {   //向服务定位器要一个服务
                TestServiceImpl t = sp.GetService<TestServiceImpl>();
                t.Name = "tom";
                t.SayHi();

                TestServiceImpl t1 = sp.GetService<TestServiceImpl>();
                t1.Name = "tim";
                t1.SayHi();
                //t1　t2は同じ対象ですか
                object.ReferenceEquals(t1, t);//false 同じ対象
                t.SayHi();//tim

            }
            #endregion

            #region AddScoped
            services.AddSingleton<TestServiceImpl>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {   
                
                TestServiceImpl s= sp.GetService<TestServiceImpl>();
                using (IServiceScope scopel = sp.CreateScope())
                {
                    //在Scope 中获取Scope相关的对象，scopel.ServiceProvide而不是sp
                    TestServiceImpl t =
                    scopel.ServiceProvider.GetService<TestServiceImpl>();
                    t.Name = "tim";
                    t.SayHi();
                    TestServiceImpl t1 =
                    scopel.ServiceProvider.GetService<TestServiceImpl>();
                    t1.Name = "tom";
                    t.SayHi();
                    Console.WriteLine(object.ReferenceEquals(t, t1));
                    s = t;
                }
                using (IServiceScope scopel2 = sp.CreateScope())
                {
                    //在Scope 中获取Scope相关的对象，scopel.ServiceProvide而不是sp
                    TestServiceImpl tt =
                    scopel2.ServiceProvider.GetService<TestServiceImpl>();
                    tt.Name = "tim";
                    tt.SayHi();
                    TestServiceImpl tt1 =
                    scopel2.ServiceProvider.GetService<TestServiceImpl>();
                    tt1.Name = "tom";
                    tt.SayHi();
                    Console.WriteLine(object.ReferenceEquals(tt, tt1));
                    Console.WriteLine(object.ReferenceEquals(s, tt1));
                }
            }
            #endregion
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
    public class TestServiceImpl : ITestService,IDisposable
    {
        public string Name { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Dispose......");
        }
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
