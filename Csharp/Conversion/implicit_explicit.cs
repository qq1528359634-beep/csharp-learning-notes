using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Conversion
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }
        //explicit conversion int to Person
        public static explicit operator Person(int age)
        {
            return new Person("Somebdoy", age);
        }
        //implicit conversion person to iny 
        public static implicit operator int(Person person)
        {
            return person.Age;
        }
    }
    internal class implicit_explicit
    {
        static void Main(string[] args)
        {
            Person person = new("Tim", 18);
            int a = 20;
            int b = 30;
            person=(Person)a;
            Console.WriteLine($"{person.Name} {person.Age}");//somebody 20
            b = person;
            Console.WriteLine(b);//20
        }
    }
}
