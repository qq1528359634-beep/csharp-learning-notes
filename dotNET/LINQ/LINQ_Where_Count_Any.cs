using System;
using System.Collections.Generic;
using System.Text;

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
            IEnumerable<Employee> employees = list.Skip(2).Take(3);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
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

}
