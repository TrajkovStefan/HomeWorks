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
                pet.PrintInfo();
            }
        }

        public static void BuyPet(string name)
        {
            T existingPet = Pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (existingPet == null)
            {
                Console.WriteLine("There is no such pet by that name");
                return;
            }
            Pets.Remove(existingPet);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The purchase was successfully completed for {existingPet.Name}");
            Console.ResetColor();
        }
    }
}
