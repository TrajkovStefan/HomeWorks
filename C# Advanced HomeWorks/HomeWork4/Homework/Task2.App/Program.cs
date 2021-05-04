using System;
using System.Collections.Generic;
using Task2.Domain.Classes;

namespace Task2.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("meat", "Roki", "dog", 5);
            Dog dog2 = new Dog("dog food", "Lusi", "dog", 3);

            Cat cat1 = new Cat(true, 9, "Kity", "cat", 2);
            Cat cat2 = new Cat(false, 8, "Miki", "cat", 4);

            Fish fish1 = new Fish("blue", "small", "Nemo", "fish", 1);
            Fish fish2 = new Fish("black", "large", "Oscar", "fish", 6);

            PetStoreGenericDb<Dog>.Pets.Add(dog1);
            PetStoreGenericDb<Dog>.Pets.Add(dog2);
            PetStoreGenericDb<Cat>.Pets.Add(cat1);
            PetStoreGenericDb<Cat>.Pets.Add(cat2);
            PetStoreGenericDb<Fish>.Pets.Add(fish1);
            PetStoreGenericDb<Fish>.Pets.Add(fish2);

            Console.WriteLine("Printing all PETS before buying");
            PetStoreGenericDb<Dog>.PrintsPets();
            PetStoreGenericDb<Cat>.PrintsPets();
            PetStoreGenericDb<Fish>.PrintsPets();

            //buying pet == remove from list
            PetStoreGenericDb<Dog>.BuyPet("roki");
            PetStoreGenericDb<Cat>.BuyPet("kity");
            PetStoreGenericDb<Fish>.BuyPet("nemo");

            Console.WriteLine("Printing all PETS after buying");
            PetStoreGenericDb<Dog>.PrintsPets();
            PetStoreGenericDb<Cat>.PrintsPets();
            PetStoreGenericDb<Fish>.PrintsPets();



            Console.ReadLine();
        }
    }
}
