
using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.DataBase;
using System;
using System.Threading;

namespace SEDC.HomeWork.TimeTracking.App
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase._users.ShowMainMenu();

            while (true)
            {
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (success)
                {
                    if (number < 1 || number > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        Console.Clear();
                        DataBase._users.ShowMainMenu();
                    }
                    if (number == 1)
                    {
                        Console.Clear();
                        DataBase._users.LogIn();
                    }
                    if (number == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter firstname");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter lastname");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter age");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password");
                        string password = Console.ReadLine();

                        DataBase._users.AddUser(new User()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Username = username,
                            Password = password,
                            Status = UserAccStatus.Activate
                        });
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successfully registered! \nPress any key to back to main menu");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        DataBase._users.ShowMainMenu();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    Console.Clear();
                    DataBase._users.ShowMainMenu();
                }
            }
        }
    }
}
