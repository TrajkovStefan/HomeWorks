using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2.Domain.Classes
{
    public static class PetStoreGenericDb<T> where T : Pet
    {
        public static List<T> Pets { get; set; }
        static PetStoreGenericDb()
        {
            Pets = new List<T>();
        }

        public static void PrintsPets()
        {
            foreach(T pet in Pets)
            {
                Console.WriteLine(pet);
            }
        }

        public static void BuyPet(T pet)
        {
            T existingPet = Pets.FirstOrDefault(x => x.Name == pet.Name);
            if(existingPet == null)
            {
                Console.WriteLine("There is no such pet by that name");
                return;
            }
            Pets.Remove(pet);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The purchase was successfully completed for {pet.Name}");
            Console.ResetColor();
        }
    }
}
