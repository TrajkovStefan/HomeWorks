using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }
        public Dog(string favoriteFood, string name, string type, int age) : base(name, type, age)
        {
            FavoriteFood = favoriteFood;
        }
        public override void PrintInfo()
        {
            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(FavoriteFood))
            {
                throw new Exception("Name and FavoriteFood must have value");
            }
            Console.WriteLine($"The dog {Name} eats his favorite food {FavoriteFood}");
        }
    }
}
