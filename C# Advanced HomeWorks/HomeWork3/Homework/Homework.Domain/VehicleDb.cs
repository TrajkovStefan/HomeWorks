using Homework.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Domain
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles { get; set; }

        static VehicleDb()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(30, new List<string>() { "England", "Germany", "Spain"}, 1, "Wagon", 2012, 9898),
                new Car(28, new List<string>() { "Russia", "USA", "Spain"}, 7, "Sedan", 2011, 0001),
                new Car(40, new List<string>() { "Holland", "Italy", "Germany"}, 8, "Coupe", 2009, 4444),
                new Bike("red", 2019, "Mountain", 2020, 7766),
                new Bike("blue", 2, "Road", 2017, 6666),
                new Bike("black", 4, "Electric", 2020, 5555),
                new Vehicle(5, "Car", 2016, 1234),
                new Vehicle(2, "Bike", 2018, 5432),
                new Vehicle(3, "Car", 2019, 8998)
            };
        }
    }
}
