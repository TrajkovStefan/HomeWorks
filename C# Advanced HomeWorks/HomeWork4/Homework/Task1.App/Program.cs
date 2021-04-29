using System;
using System.Collections.Generic;
using Task1.Domain.Classes;

namespace Task1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            GenereicDb<Shape>.Shapes.Add(new Circle() { Id = 1, Radius = 5 });
            GenereicDb<Shape>.Shapes.Add(new Rectangle() { Id = 2, SideA = 2.5, SideB = 3});


            Console.WriteLine("Area of all shapes");
            GenereicDb<Shape>.PrintAreas();

            Console.WriteLine("Perimeter of all shapes");
            GenereicDb<Shape>.PrintPerimeters();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FIRST WAY FOR PRINTING INFO");
            Console.ResetColor();

            foreach (Shape shape in GenereicDb<Shape>.Shapes)
            {
                shape.PrintInfo();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SECOND WAY FOR PRINTING INFO");
            Console.ResetColor();

            Shape circle = GenereicDb<Shape>.Shapes[0];
            circle.PrintInfo();

            Shape rectangle = GenereicDb<Shape>.Shapes[1];
            rectangle.PrintInfo();
            

            Console.ReadLine();
        }
    }
}
