using Domain.Classes;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Bear", Color="Brown", Age = 5, Gender = Gender.Female},
                new Animal(){Name = "Aligator", Color="Black", Age = 8, Gender = Gender.Male},
                new Animal(){Name = "Fish", Color="Gray", Age = 3, Gender = Gender.Female},
                new Animal(){Name = "Lion", Color="Brown", Age = 5, Gender = Gender.Male},
                new Animal(){Name = "Parrot", Color="Green", Age = 2, Gender = Gender.Male},
            };

            List<string> agedFiveOrMore = animals.Where(x => x.Age >= 5).Select(x => $"{x.Name} {x.Age}").ToList();
            List<Animal> namesStartWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
            List<Animal> allMaleBrownAnimals = animals.Where(x => x.Color == "Brown" && x.Gender == Gender.Male).ToList();
            Animal firstNameLongerThanTen = animals.FirstOrDefault(x => x.Name.Length > 10);

            foreach(string age5 in agedFiveOrMore)
            {
                Console.WriteLine(age5);
            }

            Console.WriteLine("==========");
            foreach(Animal nameStartA in namesStartWithA)
            {
                Console.WriteLine(nameStartA.Name);
            }

            Console.WriteLine("==========");
            foreach (Animal maleBrownAnimals in allMaleBrownAnimals)
            {
                Console.WriteLine($"{maleBrownAnimals.Name} {maleBrownAnimals.Color} {maleBrownAnimals.Gender}");
            }

            Console.WriteLine("==========");
            if (firstNameLongerThanTen == null)
            {
                Console.WriteLine("There is no such animal");
            }
            else
            {
                Console.WriteLine(firstNameLongerThanTen.Name);
            }

            Console.ReadLine();
        }
    }
}
