using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Domain.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, int batchNo)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNo;
        }
        public virtual void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vehicle");
            Console.ResetColor();
            Console.WriteLine($"Id:{Id} Type: {Type} Year of production: {YearOfProduction}");
        }
    }
}
