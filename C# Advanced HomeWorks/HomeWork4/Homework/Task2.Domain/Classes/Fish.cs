using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string color, string size, string name, string type, int age) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public override void PrintInfo()
        {
            if(string.IsNullOrEmpty(Color) || string.IsNullOrEmpty(Size))
            {
                throw new Exception("Color and Size must have value");
            }
            Console.WriteLine($"Fish {Name} has color: {Color} and size: {Size}");
        }
    }
}
