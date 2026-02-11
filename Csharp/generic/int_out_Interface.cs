using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic
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

    interface ICage<out T>
    {
        T Get();

    }

    class Cage : ICage<Dog>
    {
        public Dog Get()
        {
            return new Dog();
        }
    }
    interface ITrainer<in T1>
    {
        void Train(T1 t1);
    }
    class Trainer : ITrainer<Animal>
    {
        public void Train(Animal animal)
        {
            Console.WriteLine($"training {animal.Name}");
        }
    }
    internal class int_out_Interface
    {
        class Program
        {
            static void Main(string[] args)
            {
                ICage<Dog> dogCage = new Cage();
                ICage<Animal> animalCage = dogCage;
                Console.WriteLine($"{animalCage.Get()}");

                ITrainer<Animal> animalT = new Trainer();
                ITrainer<Dog> dogT = animalT;
                dogT.Train(new Dog());
            }
        }
    }
}
