
namespace Inheritance
{

    class Pet
    {
        public string? Name { get; set; }
        public string? Color { get; set; }

        //重写Tostring方法
        public override string ToString() => GetType().Name;


    }
    class Cat : Pet
    {
        public void ClimbTree() => Console.WriteLine($"The {Name} is climbing the tree.");

    }
    class Dog : Pet
    {
        public void CatchBall() => Console.WriteLine($"The {Name} is catching the ball.");

    }
    class Bird : Pet
    {
        public void Fly() => Console.WriteLine($"The {Name} is flying in the sky.");

    }
    class Kid
    {

        private Pet _pet;
        private string _FavoriteColor { get; set; }
        public Kid(Pet pet, string petName, string color)
        {
            _FavoriteColor = color;
            _pet = pet;
            _pet.Name = petName;
            _pet.Color = _FavoriteColor;
        }
        public void ChosePetColor()
        {
            Console.WriteLine($"A kid favorite Color is {_FavoriteColor}.");
            Console.WriteLine($"She Chosed a {_FavoriteColor} {_pet} and named it {_pet.Name}");

        }
        public void InteractWithPet<T>(Action<T> action) where T : Pet
        {
            if (_pet is T specializedPet)
            {
                action(specializedPet);
            }
            else
            {
                Console.WriteLine($"The pet is a {_pet}, not a {typeof(T).Name}!");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Cat();
            Kid kid = new(pet, "Tom", "yellow");
            kid.ChosePetColor();
            kid.InteractWithPet<Cat>(cat => cat.ClimbTree());
            Console.WriteLine();

            Pet pet1 = new Dog();
            Kid kid1 = new(pet1, "Ander", "white");
            kid1.ChosePetColor();
            kid1.InteractWithPet(delegate (Dog dog) { dog.CatchBall(); });
            Console.WriteLine();

            Pet pet2 = new Bird();
            Kid kid2 = new(pet2, "Kecy", "blue");
            kid2.ChosePetColor();
            kid2.InteractWithPet<Bird>(b => b.Fly());
        }

    }
}