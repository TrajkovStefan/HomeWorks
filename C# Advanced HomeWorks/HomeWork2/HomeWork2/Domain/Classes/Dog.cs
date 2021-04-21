using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Dog : Animal, IDog
    {
        public string Race { get; set; }
        public Dog(string name,int age, string color, string race) : base(name, age , color)
        {
            Race = race;
        }
        public void Bark()
        {
            Console.WriteLine("BARK BARK");
        }
    }
}
