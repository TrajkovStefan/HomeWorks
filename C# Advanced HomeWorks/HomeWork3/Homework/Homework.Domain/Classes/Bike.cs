using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Domain.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(string color, int id, string type, int yearOfProduction, int batchNo) : base(id, type, yearOfProduction, batchNo)
        {
            Color = color;
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNo;
        }
        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Bike");
            Console.ResetColor();
            Console.WriteLine($"Year of production: {YearOfProduction} Color: {Color}");
        }
    }
}
