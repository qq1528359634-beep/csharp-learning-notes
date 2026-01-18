using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegate
{
    internal class MulticastDelegate
    {
        // 1. 创建一把锁（所有线程共用这一个“钥匙”）
        internal static readonly object _locker = new object();
       static  void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            var action1 = () => { stu1.DoHomework(); };
            var action2 = () => { stu2.DoHomework(); };
            var action3 = () => { stu3.DoHomework(); };
            //var action4 = delegate () { stu3.DoHomework(); };
            //异步调用 各线程同时进行抢占资源
            //main方法调用完成 整个进程关闭 不管后台是否还有Task在运行
            var t1 = Task.Run(action1);
            var t2 = Task.Run(action2);
            var t3 = Task.Run(action3);


            #region 隐式异步调用 已被废弃
            //action1.BeginInvoke(null, null);
            //action2.BeginInvoke(null, null);
            //action3.BeginInvoke(null, null);

            #endregion
            #region 间接同步调用
            //action1();
            //action2();
            //action3();
            #endregion
            #region 单播委托 间接调用
            //action1();
            //action2();
            //action3();
            #endregion
            #region 多播委托（间接同步调用）
            //多播委托 将action2和action3都封装到action1中
            //执行顺序根据封装顺序
            //action1 += action2;
            //action1 += action3;
            //action1();
            #endregion
            #region 直接同步调用
            //stu1.DoHomework();
            //stu2.DoHomework();
            //stu3.DoHomework();
            #endregion
            for (int i = 0; i < 10; i++)
            { // Main 线程写字前也要抢锁，否则它会覆盖学生的颜色
                lock (_locker)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Main thread {i}");
                }
                Thread.Sleep(1000);
            }

        }


    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }
        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                // 2. 关键点：在修改颜色和打印之前加锁
                lock (MulticastDelegate._locker)
                {
                    Console.ForegroundColor = this.PenColor;
                    Console.WriteLine($"The student {this.ID} doing homework {i} hour(s)");
                } // 解锁：执行完这块代码后，其他线程才能进来
                //调用到sleep就睡上一秒钟 1000毫秒
                Thread.Sleep(1000);
            }
        }
    }
}
