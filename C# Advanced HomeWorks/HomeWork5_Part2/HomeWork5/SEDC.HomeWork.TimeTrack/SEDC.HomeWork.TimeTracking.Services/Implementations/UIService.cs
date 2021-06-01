using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Helpers;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.HomeWork.TimeTracking.Services.Implementations
{
    public class UIService : IUIService
    {
        public int ChooseMenuItem(List<string> menuItems)
        {
            while (true)
            {
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItems[i]}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, menuItems.Count);
                if (choice == -1)
                {
                    Console.Clear();
                    MessageHelper.PrintMessage("You must enter a valid option \nTry again...", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }
        }

        public int LogInMenu()
        {
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int ActivityMenu()
        {
            List<string> activityItems = Enum.GetNames(typeof(TrackType.Activities)).ToList(); //get the names of members of Activities enum
            Console.WriteLine("Choose activity");
            return ChooseMenuItem(activityItems);
        }
        public int ReadingMenu()
        {
            List<string> readingItems = Enum.GetNames(typeof(TrackType.ReadingType)).ToList(); //get the names of members of Reading enum
            Console.WriteLine("Choose type");
            return ChooseMenuItem(readingItems);
        }
        public int ExercisingMenu()
        {
            List<string> exercisingItems = Enum.GetNames(typeof(TrackType.ExercisingType)).ToList(); //get the names of members of Exercising enum
            Console.WriteLine("Choose type");
            return ChooseMenuItem(exercisingItems);
        }
        public int WorkingMenu()
        {
            List<string> workingItems = Enum.GetNames(typeof(TrackType.WorkingType)).ToList(); //get the names of members of Working enum
            Console.WriteLine("Choose type");
            return ChooseMenuItem(workingItems);
        }
        public int HobbyMenu()
        {
            List<string> workingItems = Enum.GetNames(typeof(TrackType.HobbiesType)).ToList(); //get the names of members of Hobby enum
            Console.WriteLine("Choose type");
            return ChooseMenuItem(workingItems);
        }
        public int AccountManagementMenu()
        {
            List<string> userAccountManagementMenu = new List<string> { "Change Password", "Change First Name", "Change LastName", "Deactivate Account", "Back" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(userAccountManagementMenu);
        }
        public int UserStatisticsMenu()
        {
            List<string> userStatisticsMenu = new List<string> { "Reading", "Exercising", "Working", "Hobbies", "Global", "Back" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(userStatisticsMenu);
        }
        public User CheckUserData()
        {
            bool flag = true;
            int counter = 3;
            while(flag)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("You must enter a username");
                }
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("You must enter a password");
                }
                DataBase.DataBase._currentUser = DataBase.DataBase._users.LogIn(username, password);
                if (DataBase.DataBase._currentUser == null)
                {
                    Console.Clear();
                    MessageHelper.PrintMessage($"User with username {username} cant be founded..You have {--counter} attempts to guess", ConsoleColor.Red);
                }
                if(counter == 0)
                {
                    MessageHelper.PrintMessage("You have no more attempts. \nGoodbye.", ConsoleColor.Red);
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
                if(DataBase.DataBase._currentUser != null)
                {
                    flag = false;
                    
                } 
            }
            return DataBase.DataBase._currentUser;
        }
        public int UserMenu()
        {
            List<string> userStatisticsMenu = new List<string> { "Account Management", "User Statistics", "Tracking Activity", "LogOut" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(userStatisticsMenu);
        }
    }
}