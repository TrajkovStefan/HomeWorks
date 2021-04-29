using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1.Domain.Classes
{
    public static class GenereicDb<T> where T : Shape
    {
        public static List<T> Shapes { get; set; }
        static GenereicDb()
        {
            Shapes = new List<T>();
        }

        public static void PrintAreas()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
        }

        public static void PrintPerimeters()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine(shape.GetPerimeter());
            }
        }
    }
}
