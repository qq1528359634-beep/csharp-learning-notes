using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic_
{
  
    class Animal
    {
        public string Move { get; set; } = "can move";

        public string Name { get; set; } = "animal";
    }
    class Dog : Animal
    {
        public string Bark { get; set; } = "barking！！";
    }
    delegate T Get<out T>();

    delegate void Care<in T>(T t1);
    internal class Program
    {
        internal Dog GetDog()
        {
            return new Dog();
        }
        internal void CareAnimal(Animal animal)
        {
            Console.WriteLine(animal.Move);
        }
       static  void Main(string[] args)
        {
            Program program = new Program();
            Get<Dog> getDog = program.GetDog;
            Get<Animal> GetAnimal = getDog;//need out
            var animal = GetAnimal();
            Console.WriteLine($"{animal}");

            Care<Animal> careAnimal = program.CareAnimal;
            Care<Dog> careDog = careAnimal;
            Dog dog = new Dog();
            careDog(dog);//can move
        }
    }
}
