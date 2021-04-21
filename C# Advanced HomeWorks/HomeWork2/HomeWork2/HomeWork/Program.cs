using Domain.Classes;
using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog ("Roki", 5, "red", "dog");
            Dog dog2 = new Dog ("Hack", 3, "yellow", "dog");
            Cat cat = new Cat ("Luna", 2, "green", "small");
            Cat cat2 = new Cat ("Lina", 4, "blue", "medium");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("dog1");
            Console.ResetColor();
            Console.WriteLine(dog.GetType());
            dog.PrintAnimal();
            dog.Bark();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("dog2");
            Console.ResetColor();
            dog2.PrintAnimal();
            dog2.Bark();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("cat1");
            Console.ResetColor();
            cat.PrintAnimal();
            Console.WriteLine(cat.Eat("fish"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("cat2");
            Console.ResetColor();
            cat2.PrintAnimal();
            Console.WriteLine(cat2.Eat("meat"));

            List<Animal> animals = new List<Animal>
            {
                dog,
                dog2,
                cat,
                cat2
            };

            try
            {
                if(animals != null)
                {
                    foreach (Animal animal in animals)
                    {
                        if (animal.GetType() == dog.GetType())
                        {
                            ((Dog)animal).Bark();
                        }
                        else if (animal.GetType() == cat.GetType())
                        {
                            Console.WriteLine(((Cat)animal).Eat("some food"));
                        }
                        else
                        {
                            throw new Exception("There is no animal that is a dog or a cat.");
                        }
                    }
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Animal does not exist");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
