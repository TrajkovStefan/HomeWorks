using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(bool lazy, int livesLeft, string name, string type, int age) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }
        public override void PrintInfo()
        {
            if(LivesLeft < 0)
            {
                throw new ArgumentException("Lives left can not be negative number");
            }
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name must have value");
            }
            if(Lazy == true)
            {
                Console.WriteLine($"The cat {Name} has {LivesLeft} lives left. She is lazy.");
            }
            else
            {
                Console.WriteLine($"The cat {Name} has {LivesLeft} lives left. She is not lazy.");
            }
        }
    }
}
