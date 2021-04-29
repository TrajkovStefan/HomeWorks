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

            PetStoreGenericDb<Pet>.Pets.Add(dog1);
            PetStoreGenericDb<Pet>.Pets.Add(dog2);
            PetStoreGenericDb<Pet>.Pets.Add(cat1);
            PetStoreGenericDb<Pet>.Pets.Add(cat2);
            PetStoreGenericDb<Pet>.Pets.Add(fish1);
            PetStoreGenericDb<Pet>.Pets.Add(fish2);

            List<Pet> listOfPets = PetStoreGenericDb<Pet>.Pets;
            listOfPets[0].PrintInfo();
            listOfPets[1].PrintInfo();
            listOfPets[2].PrintInfo();
            listOfPets[3].PrintInfo();
            listOfPets[4].PrintInfo();
            listOfPets[5].PrintInfo();

            //buying pet == remove from list
            PetStoreGenericDb<Pet>.BuyPet(dog1);
            PetStoreGenericDb<Pet>.BuyPet(cat1);

            Console.WriteLine("Printing all PETS after buying");
            PetStoreGenericDb<Pet>.PrintsPets();


            Console.ReadLine();
        }
    }
}
