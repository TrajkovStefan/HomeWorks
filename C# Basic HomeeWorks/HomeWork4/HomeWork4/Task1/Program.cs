using System;
using Task1.Modules;

namespace Task1
{
    class Program
    {
        static void RaceCars(Car carNo1, Car carNo2)
        {
            int winner = carNo1.CalculateSpeed(carNo1.Driver) - carNo2.CalculateSpeed(carNo2.Driver);
            if (winner == 0)
            {
                Console.WriteLine("It is a DRAW!");
            }
            else if (winner > 0)
            {
                Console.WriteLine($"The {carNo1.Driver.Name} is fasted with {carNo1.Model} ");
            }
            else
            {
                Console.WriteLine($"The {carNo2.Driver.Name} is fasted with {carNo2.Model}");
            }
        }

        static void Main(string[] args)
        {
            bool success = false;
            do
            {
                Car[] cars = new Car[]
                {
                new Car("Mercedes", 180),
                new Car("Bmw", 160),
                new Car("Porsche", 190),
                new Car("Seat", 150)
                };

                Driver[] drivers = new Driver[]
                {
                new Driver("Bob", 2),
                new Driver("John", 3),
                new Driver("Greg", 1),
                new Driver("Johnson", 6)
                };

                Car[] newCar = new Car[] { };
                Driver[] newDriver = new Driver[] { };


                Console.WriteLine("CARS OFFERED");
                foreach (Car car in cars)
                {
                    Console.WriteLine(car.Model);

                }

                Console.WriteLine("Choose a car no.1");
                string firstSelectedCar = Console.ReadLine();
                string firstCar = "";
                int firstSpeed = 0;
                int counter = 0;

                for (int i = 0; i < cars.Length; i++)
                {
                    if (firstSelectedCar.ToLower().Contains(cars[i].Model.ToLower()))
                    {
                        firstCar = cars[i].Model;
                        firstSpeed = cars[i].Speed;
                        continue;
                    }
                    else if (firstSelectedCar.ToLower() != cars[i].Model.ToLower())
                    {
                        Array.Resize(ref newCar, newCar.Length + 1);
                        newCar[counter++] = cars[i];
                    }
                }

                if (cars.Length == newCar.Length)
                {
                    Console.WriteLine("You are disqualified from the race because you entered wrong input");
                }

                Console.WriteLine("DRIVERS OFFERED");
                Console.WriteLine("Choose driver for car no.1");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine(driver.Name);
                }
                string firstSelectedDriver = Console.ReadLine();
                string firstDriver = "";
                int firstSkill = 0;
                int counterTwo = 0;

                for (int i = 0; i < drivers.Length; i++)
                {
                    if (firstSelectedDriver.ToLower().Contains(drivers[i].Name.ToLower()))
                    {
                        firstDriver = drivers[i].Name;
                        firstSkill = drivers[i].Skill;
                        continue;

                    }
                    else if (firstSelectedDriver.ToLower() != drivers[i].Name.ToLower())
                    {
                        Array.Resize(ref newDriver, newDriver.Length + 1);
                        newDriver[counterTwo++] = drivers[i];
                    }
                }
                if (newDriver.Length == drivers.Length)
                {
                    Console.WriteLine("You are disqualified from the race because you entered wrong input");
                }


                Console.WriteLine("CARS OFFERED");
                foreach (Car car in newCar)
                {
                    Console.WriteLine(car.Model);
                }
                Console.WriteLine("Choose a car no.2");
                string secondSelectedCar = Console.ReadLine();
                string secondCar = "";
                int secondSpeed = 0;


                for (int i = 0; i < newCar.Length; i++)
                {
                    if (secondSelectedCar.ToLower().Contains(newCar[i].Model.ToLower()))
                    {
                        secondCar = newCar[i].Model;
                        secondSpeed = newCar[i].Speed;
                        break;
                    }
                }

                if (String.IsNullOrEmpty(secondCar) && secondSpeed == 0)
                {
                    Console.WriteLine("You are disqualified from the race because you entered wrong input");
                }

                Console.WriteLine("DRIVERS OFFERED");
                Console.WriteLine("Choose driver for car no.2");
                foreach (Driver driver in newDriver)
                {
                    Console.WriteLine(driver.Name);
                }

                string secondSelectedDriver = Console.ReadLine();
                string secondDriver = "";
                int secondSkill = 0;

                for (int i = 0; i < newDriver.Length; i++)
                {
                    if (secondSelectedDriver.ToLower().Contains(newDriver[i].Name.ToLower()))
                    {
                        secondDriver = newDriver[i].Name;
                        secondSkill = newDriver[i].Skill;
                    }
                }

                if (String.IsNullOrEmpty(secondDriver) && secondSkill == 0)
                {
                    Console.WriteLine("You are disqualified from the race because you entered wrong input");
                }


                Driver firstDriverRace = new Driver(firstDriver, firstSkill);
                Driver secondDriverRace = new Driver(secondDriver, secondSkill);
                Car firstCarDriver = new Car(firstCar, firstSpeed, firstDriverRace);
                Car secondCarDriver = new Car(secondCar, secondSpeed, secondDriverRace);
                RaceCars(firstCarDriver, secondCarDriver);

                Console.WriteLine("Want again race? (y / n)");

                string response = Console.ReadLine();
                if (response == "y")
                {
                    Console.Clear();
                    success = true;
                    Console.WriteLine("Start again");
                }
                else
                {
                    Console.WriteLine("Goodbye. See ya again");
                    break;
                }
            }

            while (success == true);
            Console.ReadLine();

        }
    }
}
