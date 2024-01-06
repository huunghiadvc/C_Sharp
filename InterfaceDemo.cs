using System;

namespace InterfaceDemo
{
    interface IAnimal
    {
        void MakeSound();
    }
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Gâu Gâu Gâu Gâu Gâu");
        }
    }
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Ha ha ha ha ha ha ha ha ha ha ha ha ha ha ha ha ha ha");
        }
    }
    class Program
    {
        // static void Main(string[] args)
        // {
        //     IAnimal dog = new Dog();
        //     dog.MakeSound();
        //     IAnimal cat = new Cat();
        //     cat.MakeSound();
        //     Console.WriteLine(cat.GetType().Name);
        // }
    }
}
