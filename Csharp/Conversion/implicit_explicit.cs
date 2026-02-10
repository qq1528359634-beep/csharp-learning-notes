using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Conversion
{
    internal class implicit_explicit
    {
    }
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }
        public static explicit operator Person(int age)
        {
            return new Person("Somebdoy",age);
        }
        public static implicit operator int(Person person)
        {
            return person.Age;
        }
    }
    
    }
