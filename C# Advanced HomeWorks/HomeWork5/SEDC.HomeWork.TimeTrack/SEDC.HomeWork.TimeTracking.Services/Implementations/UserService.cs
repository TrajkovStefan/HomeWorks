using SEDC.HomeWork.TimeTracking.Domain.DataBase;
using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Helpers;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SEDC.HomeWork.TimeTracking.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDataBase<T> _dataBase { get; set; }
        public UserService()
        {
            _dataBase = new DataBase<T>();
        }

        int userId;
        public void ChangeFirstNameAndLastName(int userId)
        {
            Console.Clear();
            Console.WriteLine("Enter your new first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your new last name");
            string lastName = Console.ReadLine();

            T userDb = _dataBase.GetById(userId);
            if (userDb.FirstName == firstName && userDb.LastName == lastName)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered the current first and last name \nPress any key to try again");
                Console.ReadKey();
                Console.ResetColor();
                ChangeFirstNameAndLastName(userId);
            }
            if (!ValidationHelper.ValidateFirstNameAndLastName(firstName, lastName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input \nPress any key to try again");
                Console.ReadKey();
                Console.ResetColor();
                ChangeFirstNameAndLastName(userId);
            }
            else
            {
                userDb.FirstName = firstName;
                userDb.LastName = lastName;
                _dataBase.Update(userDb);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully changed first and last name\nPress any key to back to option menu");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                UserOptions();
            }
        }

        public void ChangePassword(int userId)
        {
            Console.Clear();
            Console.WriteLine("Enter your new password");
            string newPassword = Console.ReadLine();

            T userDb = _dataBase.GetById(userId);
            if (userDb.Password == newPassword)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered the current password \nPress any key to try again");
                Console.ReadKey();
                Console.ResetColor();
                ChangePassword(userId);
            }
            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password \nPress any key to try again");
                Console.ReadKey();
                Console.ResetColor();
                ChangePassword(userId);
            }
            else
            {
                userDb.Password = newPassword;
                _dataBase.Update(userDb);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully changed password\nPress any key to back to option menu");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                UserOptions();
            }  
        }

        public void AddUser(T user)
        {
            if (!ValidationHelper.ValidateFirstNameAndLastName(user.FirstName, user.LastName))
            {
                throw new Exception("Invalid firstname or lastname");
            }
            if (!ValidationHelper.ValidatePassword(user.Password))
            {
                throw new Exception($"Invalid password");
            }
            if (!ValidationHelper.ValidateUsername(user.Username))
            {
                throw new Exception("Invalid username");
            }
            if (!ValidationHelper.ValidateAge(user.Age))
            {
                throw new Exception("Invalid age");
            }
            _dataBase.Insert(user);
        }

        public void LogIn()
        {
            List<T> userDb = _dataBase.GetAll();
            int counter = 2;
            bool flag = false;
            while (flag == false)
            {

                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                bool findUser = userDb.Any(x => x.Username == username && x.Password == password);
                if (findUser == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"User not found. Try again, you have {counter} more chances to hit.");
                    Console.ResetColor();
                    counter--;
                    flag = false;
                    if (counter == -1)
                    {
                        Console.WriteLine("Goodbye");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }
                }
                else
                {
                    Console.Clear();
                    List<T> users = _dataBase.GetAll();
                    List<int> idUser = userDb.Where(x => x.Username == username && x.Password == password).Select(x => x.Id).ToList();
                    foreach (int u in idUser)
                    {
                        T user = _dataBase.GetById(u);
                        userId = user.Id;
                    }

                    T currentUser = _dataBase.GetById(userId);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hello {currentUser.FirstName} {currentUser.LastName} \nWhat do you want to do?");
                    Console.ResetColor();
                    Console.WriteLine("");
                    flag = true;
                }
            }

            UserOptions();
            bool f = true;
            while (f == true)
            {
                bool success = int.TryParse(Console.ReadLine(), out int option);
                if (success)
                {
                    if (option < 1 || option > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \n Processing...");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        Console.Clear();
                        UserOptions();
                    }
                    if (option == 1)
                    {
                        ChangePassword(userId);
                    }
                    if (option == 2)
                    {
                        ChangeFirstNameAndLastName(userId);
                    }
                    if (option == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You logged out \nPress any key for back to main menu");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        f = false;
                        ShowMainMenu();
                    }
                    if (option == 4)
                    {
                        ShowActivities();
                    }
                    if (option == 5)
                    {
                        CheckStatus();
                    }
                    if (option == 6)
                    {
                        UserStatistics(userId);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    Console.Clear();
                    UserOptions();
                }
            }
        }
        public void ShowMainMenu()
        {
            Console.WriteLine("WELCOME TO TIME TRACKING APP \nChoose option 1)Log in 2)Register");
        }

        public void ShowActivities()
        {
            Console.Clear();
            Console.WriteLine("1)Reading \n2)Exercising \n3)Working");
            bool suc = int.TryParse(Console.ReadLine(), out int type);
            if (suc)
            {
                if (type < 1 || type > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    Console.Clear();
                    ShowActivities();
                }
                int count = 1;
                if (type == 1)
                {
                    Console.WriteLine("Choose type from reading list");
                    foreach (string t in Enum.GetNames(typeof(TrackType.ReadingType)))
                    {
                        Console.WriteLine("{0}) {1}", count, t);
                        count++;
                    }
                    bool finish = int.TryParse(Console.ReadLine(), out int choose);
                    if (finish)
                    {
                        if (choose < 1 || choose > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again FROM THE BEGINNING \nProcessing...");
                            Console.ResetColor();
                            Thread.Sleep(4000);
                            Console.Clear();
                            ShowActivities();
                        }
                        if (choose == 1)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ReadingType = TrackType.ReadingType.Belles_Lettres;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You reading {TrackType.ReadingType.Belles_Lettres} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeReading += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                        if (choose == 2)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ReadingType = TrackType.ReadingType.Fiction;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You reading {TrackType.ReadingType.Fiction} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeReading += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                        if (choose == 3)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ReadingType = TrackType.ReadingType.Professional_Literature;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You reading {TrackType.ReadingType.Professional_Literature} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeReading += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again FROM THE BEGINNING \nProcessing...");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        Console.Clear();
                        ShowActivities();
                    }
                }
                if (type == 2)
                {
                    Console.WriteLine("Choose type from exercising list");
                    foreach (string t in Enum.GetNames(typeof(TrackType.ExercisingType)))
                    {
                        Console.WriteLine("{0}) {1}", count, t);
                        count++;
                    }
                    bool finish = int.TryParse(Console.ReadLine(), out int choose);
                    if (finish)
                    {
                        if (choose < 1 || choose > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again FROM THE BEGINNING \nProcessing...");
                            Console.ResetColor();
                            Thread.Sleep(4000);
                            Console.Clear();
                            ShowActivities();
                        }
                        if (choose == 1)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ExercisingType = TrackType.ExercisingType.General;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You practice {TrackType.ExercisingType.General} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeExercising += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                        if (choose == 2)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ExercisingType = TrackType.ExercisingType.Running;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You practice {TrackType.ExercisingType.Running} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeExercising += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                        if (choose == 3)
                        {
                            T user = _dataBase.GetById(userId);
                            user.ExercisingType = TrackType.ExercisingType.Sport;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You practice {TrackType.ExercisingType.Sport} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeExercising += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                    }
                }
                if (type == 3)
                {
                    Console.WriteLine("Choose type from working list");
                    foreach (string t in Enum.GetNames(typeof(TrackType.WorkingType)))
                    {
                        Console.WriteLine("{0}) {1}", count, t);
                        count++;
                    }
                    bool finish = int.TryParse(Console.ReadLine(), out int choose);
                    if (finish)
                    {
                        if (choose < 1 || choose > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again FROM THE BEGINNING \nProcessing...");
                            Console.ResetColor();
                            Thread.Sleep(4000);
                            Console.Clear();
                            ShowActivities();
                        }
                        if (choose == 1)
                        {
                            T user = _dataBase.GetById(userId);
                            user.WorkingType = TrackType.WorkingType.Office;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You working at {TrackType.WorkingType.Office} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeWorking += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                        if (choose == 2)
                        {
                            T user = _dataBase.GetById(userId);
                            user.WorkingType = TrackType.WorkingType.Home;
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine($"You working from {TrackType.WorkingType.Home} {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                user.TimeWorking += Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                Console.WriteLine("Press any key to back to option menu");
                                Console.ReadKey();
                                Console.Clear();
                                UserOptions();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input.. Wait a few seconds for the process to complete to try again \nProcessing...");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
                ShowActivities();
            }
        }

        public void DeactivateAcc(int userId)
        {
            T userDb = _dataBase.GetById(userId);

            Console.Clear();
            userDb.Status = UserAccStatus.Deactivate;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successfully deactivated account");
            Console.ResetColor();
            Console.WriteLine("Press any key tok back to main menu");
            Console.ReadKey();
            Console.Clear();
            UserOptions();
        }

        public void ActivateAcc(int userId)
        {
            T userDb = _dataBase.GetById(userId);

            Console.Clear();
            userDb.Status = UserAccStatus.Activate;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successfully activated account");
            Console.ResetColor();
            Console.WriteLine("Press any key to back to option menu");
            Console.ReadKey();
            Console.Clear();
            UserOptions();
        }

        public void UserStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            user.GetInfo();
            Console.ResetColor();

            Console.WriteLine("Press any key to back to option menu");
            Console.ReadKey();
            Console.Clear();
            UserOptions();

        }

        public void UserOptions()
        {
            Console.WriteLine("Choose from this list");
            Console.WriteLine("");
            Console.WriteLine("1)Change Password \n2)Change First and Last name \n3)LogOut \n4)Activities for tracking" +
                                      "\n5)Check Status \n6)User Statistics ");
        }

        public void CheckStatus()
        {
            T user = _dataBase.GetById(userId);
            if (user.Status == UserAccStatus.Activate)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Status is activated");
                Console.ResetColor();
                Console.WriteLine("Do you want to deactivate account (yes or no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    DeactivateAcc(userId);
                    return;
                }
                if (answer == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Press any key to back to option menu");
                    Console.ReadKey();
                    Console.Clear();
                    UserOptions();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input... Press any key to try again");
                    Console.ResetColor();
                    Console.ReadKey();
                    CheckStatus();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Status is deactivate");
                Console.ResetColor();
                Console.WriteLine("Do you want to activate account (yes or no)");
                string answ = Console.ReadLine();
                if (answ == "yes")
                {
                    ActivateAcc(userId);
                    return;
                }
                if (answ == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Press any key to back to option menu");
                    Console.ReadKey();
                    Console.Clear();
                    UserOptions();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input... Press any key to try again");
                    Console.ResetColor();
                    Console.ReadKey();
                    CheckStatus();
                }
            }
        }
    }
}