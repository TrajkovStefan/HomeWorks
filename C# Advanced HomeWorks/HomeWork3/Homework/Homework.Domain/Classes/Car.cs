using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.Domain.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public Car(int fuelTank, List<string> countries, int id, string type, int yearOfProduction, int batchNo) : base(id, type, yearOfProduction, batchNo)
        {
            FuelTank = fuelTank;
            Countries = countries;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNo;
        }
        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Car");
            Console.ResetColor();
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine("Countries in which it is produced:");
            foreach (string vehicle in Countries)
            {
                Console.WriteLine(vehicle);
            }
            
        }
    }
}
