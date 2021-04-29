using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Domain.Classes
{
    public static class PrintHelper
    {
        public static void PrintInfo(this Shape shape)
        {
            Console.WriteLine($"Id: {shape.Id}, Type:{shape.GetType()}");
        }
    }
}
