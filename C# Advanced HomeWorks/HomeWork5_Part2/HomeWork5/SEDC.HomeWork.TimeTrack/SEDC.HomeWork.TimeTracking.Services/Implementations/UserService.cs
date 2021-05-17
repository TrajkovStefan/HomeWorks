using SEDC.HomeWork.TimeTracking.Domain.DataBase;
using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Helpers;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SEDC.HomeWork.TimeTracking.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDataBase<T> _dataBase { get; set; }
        public UserService()
        {
            _dataBase = new DataBase<T>();
        }
        public void ChangeLastName(int userId)
        {
            Console.Clear();
            Console.WriteLine("Enter your new last name");
            string lastName = Console.ReadLine();

            T userDb = _dataBase.GetById(userId);
            if (userDb.LastName == lastName)
            {
                MessageHelper.PrintMessage("You entered the current last name \nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                ChangeLastName(userId);
            }
            if (!ValidationHelper.ValidateName(lastName))
            {
                MessageHelper.PrintMessage("Wrong input \nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                ChangeLastName(userId);
            }
            else
            {
                userDb.LastName = lastName;
                _dataBase.Update(userDb);
                MessageHelper.PrintMessage("Successfully changed last name\nPress any key to back to option menu", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ChangeFirstName(int userId)
        {
            Console.Clear();
            Console.WriteLine("Enter your new first name");
            string firstName = Console.ReadLine();

            T userDb = _dataBase.GetById(userId);
            if (userDb.FirstName == firstName)
            {
                MessageHelper.PrintMessage("You entered the current first name\nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                ChangeFirstName(userId);
            }
            if (!ValidationHelper.ValidateName(firstName))
            {
                MessageHelper.PrintMessage("Wrong input \nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                ChangeFirstName(userId);
            }
            else
            {
                userDb.FirstName = firstName;
                _dataBase.Update(userDb);
                MessageHelper.PrintMessage("Successfully changed first name\nPress any key to back to option menu", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
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
                MessageHelper.PrintMessage("You entered the current password \nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                Console.Clear();
                ChangePassword(userId);
            }
            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                MessageHelper.PrintMessage("Invalid Password \nPress any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                ChangePassword(userId);
            }
            else
            {
                userDb.Password = newPassword;
                _dataBase.Update(userDb);
                MessageHelper.PrintMessage("Successfully changed password\nPress any key to back to option menu", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void AddUser(T user)
        {
            if (!ValidationHelper.ValidateName(user.FirstName) || !ValidationHelper.ValidateName(user.LastName))
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

        public T LogIn(string username, string password)
        {
            T userDb = _dataBase.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if (userDb == null)
            {
                return null;
            }
            if (userDb.Status == UserAccStatus.Deactivate)
            {
                bool flag = true;
                while (flag)
                {
                    Console.Clear();
                    MessageHelper.PrintMessage($"You cant login because your account is deactivated \n" +
                    $"If you want to log in, you must activate your account", ConsoleColor.Red);
                    MessageHelper.PrintMessage("Do you want to activate account (yes or no)", ConsoleColor.White);
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        DataBase.DataBase._users.ActivateAcc(DataBase.DataBase._currentUser.Id);
                        flag = false;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        Console.Clear();
                        MessageHelper.PrintMessage("Your account is still deactivated.", ConsoleColor.Red);
                        MessageHelper.PrintMessage("Press any key to back to log in menu.", ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();
                        DataBase.DataBase._uiService.LogInMenu();
                        Console.Clear();
                        DataBase.DataBase._uiService.CheckUserData();
                        flag = false;
                    }
                    else
                    {
                        MessageHelper.PrintMessage("Invalid input.. Press any key to try again..", ConsoleColor.Red);
                        Console.ReadKey();
                        Console.Clear();
                        flag = true;
                    }
                }
            }
            else
            {
                Console.Clear();
                MessageHelper.PrintMessage($"Hello {userDb.FirstName} {userDb.LastName}", ConsoleColor.Green);
            }
            return userDb;
        }
        public void DeactivateAcc(int userId)
        {
            T userDb = _dataBase.GetById(userId);

            Console.Clear();
            userDb.Status = UserAccStatus.Deactivate;
            MessageHelper.PrintMessage("Successfully deactivated account", ConsoleColor.Green);
            Console.WriteLine("Press any key to back to login menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void ActivateAcc(int userId)
        {
            T userDb = _dataBase.GetById(userId);

            Console.Clear();
            userDb.Status = UserAccStatus.Activate;
            MessageHelper.PrintMessage("Successfully activated account", ConsoleColor.Green);
            Console.WriteLine("Press any key to back to option menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void CheckStatus(int userId)
        {
            T user = _dataBase.GetById(userId);
            Console.WriteLine("Do you want to activate account (yes or no)");
            string answ = Console.ReadLine();
            if (answ.ToLower() == "yes")
            {
                ActivateAcc(userId);
                return;
            }
            if (answ.ToLower() == "no")
            {
                Console.Clear();
                DataBase.DataBase._uiService.LogInMenu();
                Console.Clear();
                DataBase.DataBase._uiService.CheckUserData();
                return;
            }
            else
            {
                Console.Clear();
                MessageHelper.PrintMessage("Invalid input...Press any key to try again", ConsoleColor.Red);
                Console.ReadKey();
                CheckStatus(userId);
            }
        }
        public T Register(T newUser)
        {
            newUser = (T)new User();
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            bool success = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            if (!ValidationHelper.ValidateName(firstName) || ValidationHelper.ValidateName(lastName) || !ValidationHelper.ValidateAge(age)
                || !ValidationHelper.ValidateUsername(username) || !ValidationHelper.ValidatePassword(password) || !success)
            {
                MessageHelper.PrintMessage("User data is invalid", ConsoleColor.Red);
            }

            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Age = age;
            newUser.Username = username;
            newUser.Password = password;
            newUser.Status = UserAccStatus.Activate;

            MessageHelper.PrintMessage($"{newUser.FirstName} {newUser.LastName} successfully registers your account.", ConsoleColor.Green);
            Console.WriteLine("Press any key to back main menu");
            Console.ReadKey();
            Console.Clear();
            int id = _dataBase.Insert(newUser);
            return _dataBase.GetById(id);
        }
        public void AddingReadingActivity(int userId)
        {
            Console.Clear();
            int readingOption = DataBase.DataBase._uiService.ReadingMenu();
            T user = _dataBase.GetById(userId);
            Reading predifined = DataBase.DataBase._readingTrack.FindActivityById(readingOption);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                stopwatch.Stop();
                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                Console.WriteLine("Enter the name of the book you are reading");
                string bookTitle = Console.ReadLine();
                Console.WriteLine($"You were reading the book {bookTitle} - {Math.Round(stopwatchElapsed.TotalMinutes, 3)} minutes");
                if(readingOption == 1)
                {
                    predifined.ReadingType = TrackType.ReadingType.Belles_Lettres;
                }
                if(readingOption == 2)
                {
                    predifined.ReadingType = TrackType.ReadingType.Fiction;
                }
                if(readingOption == 3)
                {
                    predifined.ReadingType = TrackType.ReadingType.Professional_Literature;
                }
                predifined.Time = Math.Round(stopwatch.Elapsed.TotalMinutes, 3);
                predifined.Pages += 20;
                user.ListOfActivities.Add(predifined);
                user.TimeReading += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                Console.WriteLine("Press any key to back to option menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AddingExercisingActivity(int userId)
        {
            Console.Clear();
            int exercisingOption = DataBase.DataBase._uiService.ExercisingMenu();
            T user = _dataBase.GetById(userId);
            Exercising predifined = DataBase.DataBase._exercisingTrack.FindActivityById(exercisingOption);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                stopwatch.Stop();
                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                Console.WriteLine("Are you tired?");
                string tired = Console.ReadLine();
                Console.WriteLine($"You exercising {Math.Round(stopwatchElapsed.TotalMinutes, 3)} minutes, Tired - {tired}");
                if (exercisingOption == 1)
                {
                    predifined.ExercisingType = TrackType.ExercisingType.General;
                }
                if (exercisingOption == 2)
                {
                    predifined.ExercisingType = TrackType.ExercisingType.Running;
                }
                if (exercisingOption == 3)
                {
                    predifined.ExercisingType = TrackType.ExercisingType.Sport;
                }
                predifined.Time = Math.Round(stopwatch.Elapsed.TotalMinutes, 3);
                user.ListOfActivities.Add(predifined);
                user.TimeExercising += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                Console.WriteLine("Press any key to back to option menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AddingWorkingActivity(int userId)
        {
            Console.Clear();
            int workingOption = DataBase.DataBase._uiService.WorkingMenu();
            T user = _dataBase.GetById(userId);
            Working predifined = DataBase.DataBase._workingTrack.FindActivityById(workingOption);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                stopwatch.Stop();
                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                Console.WriteLine("Where do you better work from? (home or office)");
                string answer = Console.ReadLine();
                Console.WriteLine($"You working from {answer} {Math.Round(stopwatchElapsed.TotalMinutes, 3)} minutes");
                if(workingOption == 1)
                {
                    predifined.WorkingType = TrackType.WorkingType.Office;
                    predifined.WorkingHoursFromOffice += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                }
                if (workingOption == 2)
                {
                    predifined.WorkingType = TrackType.WorkingType.Home;
                    predifined.WorkingHoursFromHome += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                }
                predifined.Time = Math.Round(stopwatch.Elapsed.TotalMinutes, 3);
                user.ListOfActivities.Add(predifined);
                user.TimeWorking += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                Console.WriteLine("Press any key to back to option menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AddingHobbyActivity(int userId)
        {
            Console.Clear();
            int hobbyOption = DataBase.DataBase._uiService.HobbyMenu();
            T user = _dataBase.GetById(userId);
            Hobbies predifined = DataBase.DataBase._hobbyTrack.FindActivityById(hobbyOption);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Tracking is started... \nWhen you want to stop press enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                stopwatch.Stop();
                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                if (hobbyOption == 1)
                {
                    predifined.HobbiesType = TrackType.HobbiesType.Photography;
                    Console.WriteLine("What did you photograph today?");
                    string answer = Console.ReadLine();
                    Console.WriteLine($"You photographed a {answer} {Math.Round(stopwatchElapsed.TotalMinutes, 3)} minutes");

                }
                if (hobbyOption == 2)
                {
                    predifined.HobbiesType = TrackType.HobbiesType.Bartender;
                    Console.WriteLine("Did you make cocktails today?(yes or no)");
                    string answer = Console.ReadLine();
                    Console.WriteLine($"He made cocktails: {answer} {Math.Round(stopwatchElapsed.TotalMinutes, 3)} minutes");

                }
                predifined.Time = Math.Round(stopwatch.Elapsed.TotalMinutes, 3);
                user.ListOfActivities.Add(predifined);
                user.TimeHobbies += Math.Round(stopwatchElapsed.TotalMinutes, 3);
                Console.WriteLine("Press any key to back to option menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void UserReadingStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);
            double totalTimeInHours = user.TimeReading / 60;
            int totalPages = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Reading).Sum(x => ((Reading)x).Pages);
            List<Track> numberOfReadingActivities = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Reading).ToList();
            List<Track> numberOfExercisingActivities = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Exercising).ToList();
            List<Track> numberOfWorkingActivities = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Working).ToList();
            
            TrackType.ReadingType favouriteType = numberOfReadingActivities.OrderByDescending(x => x.Time).Select(x => x.ReadingType).FirstOrDefault();
            double averageOfAllReadingActivitiesRecords = Math.Round(user.TimeReading / numberOfReadingActivities.Count, 3);
            Console.Clear();
            MessageHelper.PrintMessage($"Total time for reading {totalTimeInHours} hours" +
                $"\nAverage of all reading activities in minutes: {averageOfAllReadingActivitiesRecords} minutes" +
                $"\nTotal pages: {totalPages}" +
                $"\nFavourite Type: {favouriteType}", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
        }
        public void UserExercisingStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);
            double totalTimeInHours = user.TimeExercising / 60;
            List<Track> numberOfExercisingActivities = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Exercising).ToList();
            TrackType.ExercisingType favouriteType = numberOfExercisingActivities.OrderByDescending(x => x.Time).Select(x => x.ExercisingType).FirstOrDefault();
            double averageOfAllExercisingActivitiesRecords = Math.Round(user.TimeExercising / numberOfExercisingActivities.Count, 3);
            Console.Clear();
            MessageHelper.PrintMessage($"Total time for exercising {totalTimeInHours} hours" +
                $"\nAverage of all exercising activities: {averageOfAllExercisingActivitiesRecords} minutes" +
                $"\nFavourite Type: {favouriteType}", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
        }
        public void UserWorkingStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);
            double totalTimeInHours = user.TimeWorking / 60;
            List<Track> numberOfWorkingActivities = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Working).ToList();
            double averageOfAllWorkingActivitiesRecords = Math.Round(user.TimeWorking / numberOfWorkingActivities.Count, 3);
            double homeHours = user.ListOfActivities.Where(x => x.WorkingType == TrackType.WorkingType.Home).Sum(x => ((Working)x).WorkingHoursFromHome);
            double officeHours = user.ListOfActivities.Where(x => x.WorkingType == TrackType.WorkingType.Office).Sum(x => ((Working)x).WorkingHoursFromOffice);
            double totalHomeHours = homeHours / 60;
            double totalOfficeHours = officeHours / 60;
            Console.Clear();
            MessageHelper.PrintMessage($"Total time for working {totalTimeInHours} hours" +
                $"\nAverage of all working activities: {averageOfAllWorkingActivitiesRecords} minutes \nWorking from home {homeHours} hours" +
                $"\nWorking from office {officeHours} hours", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
        }
        public void UserHobbiesStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);
            double totalTimeInHours = user.TimeHobbies / 60;
            List<Track> listOfAllRecordedNamesOfHobbies = user.ListOfActivities.Where(x => x.Activity == TrackType.Activities.Hobbies).ToList();
            Console.Clear();
            MessageHelper.PrintMessage("All recorded hobbies", ConsoleColor.Green);
            foreach(var names in listOfAllRecordedNamesOfHobbies)
            {
                Console.WriteLine(names.HobbiesType);
            }
            MessageHelper.PrintMessage($"Total hours {totalTimeInHours} hours", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
        }
        public void UserGlobalStatistics(int userId)
        {
            T user = _dataBase.GetById(userId);
            double totalTime = user.TimeReading + user.TimeExercising + user.TimeWorking + user.TimeHobbies / 60;
            TrackType.Activities favouriteActivity = user.ListOfActivities.OrderByDescending(x => x.Time).Select(x => x.Activity).FirstOrDefault();
            MessageHelper.PrintMessage($"Total time of all activities {totalTime} hours \nFavourite activity: {favouriteActivity}", ConsoleColor.Green);
        }
    }
}


