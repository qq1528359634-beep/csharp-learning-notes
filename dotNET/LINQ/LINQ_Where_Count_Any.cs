using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace dotNET.LINQ
{
    internal class LINQ_Where_Count_Any
    {

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
            list.Add(new Employee { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
            list.Add(new Employee { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
            list.Add(new Employee { Id = 4, Name = "lucy", Age = 16, Gender = false, Salary = 2000 });
            list.Add(new Employee { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
            list.Add(new Employee { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
            list.Add(new Employee { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
            list.Add(new Employee { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });
            #region Where Count Any
            /* //Where
             IEnumerable<Employee> newList = list.Where(a => a.Age > 30);
             foreach (var item in newList)
             {
                 Console.WriteLine(item);
             }
             //Count()
             list.Count();//8
             var a = list.Count(e => e.Salary > 5000 && e.Age > 30);
             Console.WriteLine(a);
             //Any
             list.Any();//true
             var b = list.Any(e => e.Salary > 10000);//true
             Console.WriteLine(b);*/
            #endregion

            #region Single SingleOrDefault First FirstOrDefault
            /*Employee e1 = list.Single(e => e.Name == "jim");
            Console.WriteLine(e1);
            Employee e2 = list.SingleOrDefault(e => e.Name == "Tom");
            Console.WriteLine(e2 == null);

            int[] nums = { 1, 8, 10, 11 };
            int num = nums.SingleOrDefault(num => num > 12);
            Console.WriteLine(num);

            Employee e3 = list.First(e => e.Id > 2);
            Console.WriteLine(e3);
            Employee e4 = list.FirstOrDefault(e => e.Id > 10);
            Console.WriteLine(e4 == null);*/
            #endregion

            #region OrderBy OrderByDesending
            //IEnumerable<Employee> e5 = list.OrderBy(e=>e.Salary);
            //foreach (var item in e5)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //IEnumerable<Employee> e6 = list.OrderByDescending(e=>e.Salary);
            //foreach (var item in e6)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            #endregion

            #region ThenBy ThenByDescending
            //IEnumerable<Employee> e7 = list.OrderBy(e => e.Age).ThenByDescending(e=>e.Salary);
            //foreach (var item in e7)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Skip Taken
            /* IEnumerable<Employee> employees = list.Skip(2).Take(3);
             foreach (Employee employee in employees)
             {
                 Console.WriteLine(employee);
             }
             #endregion
             #region Max Min Average Sum Count
              long max = list.Max(x => x.Id);
             Console.WriteLine(max);

             int a = list.Where(a => a.Age > 30).Count();
             Console.WriteLine(a);

             string s = list.Max(x => x.Name);
             Console.WriteLine(s);

             double b = list.Where(e => e.Age > 30).Average(e => e.Salary);
             Console.WriteLine(b);*/
            #endregion

            #region GroundBy
            /* IEnumerable<IGrouping<int,Employee>> items=list.GroupBy(e => e.Age);
             foreach ( IGrouping<int, Employee> g in items)
             {
                 Console.WriteLine(g.Key);
                 Console.WriteLine("Best Salary"+g.Max(e=>e.Salary));
                 foreach (Employee e in g)
                 {
                     Console.WriteLine(e);
                 }
             }*/
            #endregion

            #region Select
            IEnumerable<int> ages = list.Select(x => x.Age);
            foreach (var item in ages)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> strings = list.Select(e => e.Name);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            var strs = list.Select(e => e.Name + " " + e.Salary);
            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> items = list.Where(e => e.Age > 30)
                .Select(e => e.Gender ? "male" : "female");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            IEnumerable<Person> persons = list.Select(e => new Person
            {
                PersonAge = e.Age,
                PersonName = e.Name,
            });
            foreach (var item in persons)
            {
                Console.WriteLine(item.PersonAge + "  " + item.PersonName);
            }


            #endregion

            #region Anonymous Type
            var itmes = list.Select(e => new
            {
                XingMing = e.Name,
                NianLing = e.Age,
                XingBie = e.Gender ? "male" : "female"
            });
            foreach (var item in itmes)
            {
                Console.WriteLine(item.XingMing + "" + item.XingBie);
            }
            //用GoupBy中的新值重新生成一个匿名类
            var items1 = list.GroupBy(e => e.Age).Select(e => new
            {
                Age = e.Key,
                MaxSalary = e.Max(e => e.Salary),
                MinSalary = e.Min(e => e.Salary),
                Members = e.Count()
            });
            foreach (var item in items1)
            {
                Console.WriteLine(item.MinSalary + "" + item.Members);
            }
            #endregion

            #region IEnumerable ToArray ToList
            IEnumerable<Employee> items2 = list.Where(e => e.Salary > 5000);
            List<Employee> employees = items2.ToList();
            Employee[] employees1 = employees.ToArray();
            #endregion

            #region Chained calls
            var members = list.Where(e => e.Id > 2).GroupBy(e => e.Age)
                .OrderBy(e => e.Key).Take(3).Select(e => new
                {
                  Age1=e.Key,AverageSalar=e.Average(e=>e.Salary)
                  ,Members = e.Count()
                });
           foreach( var item in members)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

    }
    class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }//姓名
        public int Age { get; set; }//年龄
        public bool Gender { get; set; }//性别
        public int Salary { get; set; }//月薪
        public override string ToString()
        {
            return $"Id={Id},Name={Name},Age={Age},Gender={Gender},Salary={Salary}";
        }


    }
    class Person
    {
        public int PersonAge { get; set; }
        public string PersonName { get; set; }
    }

}
