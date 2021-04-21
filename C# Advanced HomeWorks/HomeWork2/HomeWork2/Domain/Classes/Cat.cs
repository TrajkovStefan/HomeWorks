using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Cat : Animal, ICat
    {
        public string Size { get; set; }
        public Cat(string name, int age, string color, string size) : base(name, age, color)
        {
            Size = size;
        }

        public string Eat(string food)
        {
            return $"The cat {Name} eating {food}";
        }
    }
}
