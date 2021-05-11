using SEDC.HomeWork.TimeTracking.Domain.DataBase;
using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Helpers;
using SEDC.HomeWork.TimeTracking.Services.Implementations;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SEDC.HomeWork.TimeTracking.App
{
    class Program
    {
        public static IUserService<User> _users = new UserService<User>();
        public static ITrackService<Exercising> _exercisingTrack = new TrackService<Exercising>();
        public static ITrackService<Reading> _readingTrack = new TrackService<Reading>();
        public static ITrackService<Working> _workingTrack = new TrackService<Working>();
        
        static void Main(string[] args)
        {

            _users.AddUser(new User()
            {
                FirstName = "Marko",
                LastName = "Markovski",
                Age = 20,
                Password = "M123456",
                Username = "mmarkovski",
                Status = UserAccStatus.Activate,
            });

            _users.AddUser(new User()
            {
                FirstName = "Stefan",
                LastName = "Stefanovski",
                Age = 23,
                Password = "S123456",
                Username = "sstefanovski",
                Status = UserAccStatus.Activate,
            });

            _users.AddUser(new User()
            {
                FirstName = "Petko",
                LastName = "Petkovski",
                Age = 28,
                Password = "P123456",
                Username = "ppetkovski",
                Status = UserAccStatus.Activate,

            });

            _exercisingTrack.AddTrack(new Exercising()
            {
                Title = "General Exercising",
                Description = "some exercise",
                Time = 35.5,
                ExercisingType = new List<TrackType.ExercisingType>() { TrackType.ExercisingType.General, 
                                         TrackType.ExercisingType.Running, TrackType.ExercisingType.Sport}

            });

            _readingTrack.AddTrack(new Reading()
            {
                Pages = 20,
                Title = "Reading",
                Description = "some read",
                Time = 20.5,
                ReadingType = new List<TrackType.ReadingType>() { TrackType.ReadingType.Belles_Lettres, 
                                        TrackType.ReadingType.Fiction, TrackType.ReadingType.Professional_Literature}
            });

            _workingTrack.AddTrack(new Working()
            {
                Title = "Working at work",
                Description = "some work",
                Time = 80,
                WorkingType = new List<TrackType.WorkingType>() { TrackType.WorkingType.Home, TrackType.WorkingType.Office}
            });

            _users.ShowMainMenu();
     
            while (true)
            {
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (success)
                {
                    if(number < 1 || number > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        Console.Clear();
                        _users.ShowMainMenu();
                    }
                    if (number == 1)
                    {
                        Console.Clear();
                        _users.LogIn();
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

                        _users.AddUser(new User()
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
                        _users.ShowMainMenu();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    Console.Clear();
                    _users.ShowMainMenu();
                }
            }
        }
    }
}
