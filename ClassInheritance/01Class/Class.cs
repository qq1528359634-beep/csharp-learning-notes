using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Csharp._01Class
{
    class Student
    {   //类是一种数据结构 date structure  当前student类就有2组件1个方法
        //类是对现实中事物的抽象的载体 他的成员代表从现实生活抽象对象的属性
        //类是一种数据类型(引用类型),自定义的数据类型
        public int ID;
        public string Name;
        //静态成员代表学生总数 属于Student 通过类访问 而非实例
        public static int Amount {  get; set; }
        static Student()
        {
            Amount = 0; 
           
        }
        //自定义构造器（函数）
        public Student(int id,string name)
        {
              ID = id;
            Name = name;
            //每创建一个学生Amount就加一
            Amount++;
        }
        public void Reporty()
        {
            Console.WriteLine($"I am {ID} student,My name is {Name}");
        }
        //析构器 回收资源 当程序结束时调用析构器 不重要
        // ~Student() { Console.WriteLine("ByeBye"); }
        //~Student() { Amount--; }
    }
     class Class
    {
         void Main(string[] args)
        {  //类型可以创建变量  类型可以创建实例  默认初始化构造器
           // Student student = new Student() { Name = "Tim", ID = 100 }; 

            //自定义构造器
            Student student=new Student(100,"Tim");
            student.Reporty();
           

            //读取Student类型被储存于t中 反射的原理
            Type t=typeof(Student);  
            //通过类型创建对象
            object o=Activator.CreateInstance(t,1,"Tim");
            Console.WriteLine(o.GetType().Name);
            Student stu=o as Student;
            stu.Reporty();
            Console.WriteLine(Student.Amount);
        }
    }


}
