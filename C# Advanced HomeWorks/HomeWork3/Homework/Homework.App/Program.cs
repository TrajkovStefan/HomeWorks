using Homework.Domain;
using Homework.Domain.Classes;
using System;

namespace Homework.App
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Vehicle vehicle in VehicleDb.Vehicles)
            {
                vehicle.PrintVehicle();
            }

            Console.WriteLine(Validator.Validate(VehicleDb.Vehicles[0]));
            Console.WriteLine(Validator.Validate(VehicleDb.Vehicles[3]));
            Console.WriteLine(Validator.Validate(VehicleDb.Vehicles[6]));

            Console.ReadLine();
        }
    }
}
