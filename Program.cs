using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_6_W
{
    internal class Program
    {
        class Animal
        {
            public string NameAnimal;
            public string food;
            public string location;
            public string setFood()
            {
                return food;
            }

            public Animal(string NameAnimal, string food, string location)
            {
                this.NameAnimal = NameAnimal;
                this.food = food;
                this.location = location;
            }
            public void eat()
            {
                Console.WriteLine("*звуки поедания пищи* \n ест ");
            }
            public void makeNoise()
            {
                Console.WriteLine("шумит");
            }
            public void sleep()
            {

                Console.WriteLine("Животное спит");
            }
        }
        class Dog : Animal
        {
            public string NameAnimal;

            public Dog(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} гавкает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Cat : Animal
        {
            public string NameAnimal;

            public Cat(string NameAnimal, string food, string location) : base(NameAnimal,food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} мяукает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Hourse : Animal
        {
            public string NameAnimal;

            public Hourse(string NameAnimal, string food, string location) : base(NameAnimal,food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} цокает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Veterenar
        {

            public void treatAnimal(Animal animal)
            {
                Console.WriteLine("еда :" + animal.food);
                Console.WriteLine("Место жительства: " + animal.location);
                Console.WriteLine(animal.NameAnimal + " на приеме у Ветеринара\n");
            }
        }
        static void Main(string[] args)
        {
            Veterenar veterenar = new Veterenar();

            Dog dog = new Dog("Малыш", "Хлеб, мясо и морковка", "дома");
            Cat cat = new Cat("Валера", "все мясные продуты и вообще всё что угодно", "будка");
            Hourse hourse = new Hourse("Игогоша", "марковка и яблоки", "конюшня");

            veterenar.treatAnimal(dog);
            veterenar.treatAnimal(cat);
            veterenar.treatAnimal(hourse);

            Console.ReadLine();
        }
    }
}
