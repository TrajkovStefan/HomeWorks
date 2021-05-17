
using SEDC.HomeWork.TimeTracking.Services.DataBase;
using SEDC.HomeWork.TimeTracking.Services.Helpers;
using System;

namespace SEDC.HomeWork.TimeTracking.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool flag1 = true;
                int option = DataBase._uiService.LogInMenu();
                Console.Clear();
                if (option == 1)
                {
                    DataBase._uiService.CheckUserData();
                    while (flag1)
                    {
                        int userOption = DataBase._uiService.UserMenu();
                        Console.Clear();
                        if (userOption == 1)
                        {
                            int accountManagementOption = DataBase._uiService.AccountManagementMenu();
                            if (accountManagementOption == 1)
                            {
                                DataBase._users.ChangePassword(DataBase._currentUser.Id);
                            }
                            if (accountManagementOption == 2)
                            {
                                DataBase._users.ChangeFirstName(DataBase._currentUser.Id);

                            }
                            if (accountManagementOption == 3)
                            {
                                DataBase._users.ChangeLastName(DataBase._currentUser.Id);
                            }
                            if (accountManagementOption == 4)
                            {
                                DataBase._users.DeactivateAcc(DataBase._currentUser.Id);
                                flag1 = false;
                            }
                            if(accountManagementOption == 5)
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                        if(userOption == 2)
                        {
                            int activityOption = DataBase._uiService.UserStatisticsMenu();
                            if(activityOption == 1)
                            {
                                DataBase._users.UserReadingStatistics(DataBase._currentUser.Id);
                            }
                            if(activityOption == 2)
                            {
                                DataBase._users.UserExercisingStatistics(DataBase._currentUser.Id);
                            }
                            if(activityOption == 3)
                            {
                                DataBase._users.UserWorkingStatistics(DataBase._currentUser.Id);
                            }
                            if(activityOption == 4)
                            {
                                DataBase._users.UserHobbiesStatistics(DataBase._currentUser.Id);
                            }
                            if(activityOption == 5)
                            {
                                DataBase._users.UserGlobalStatistics(DataBase._currentUser.Id);
                            }
                            if(activityOption == 6)
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                        if(userOption == 3)
                        {
                            int activityOption = DataBase._uiService.ActivityMenu();
                            if(activityOption == 1)
                            {
                                DataBase._users.AddingReadingActivity(DataBase._currentUser.Id);
                            }
                            if(activityOption == 2)
                            {
                                DataBase._users.AddingExercisingActivity(DataBase._currentUser.Id);
                            }
                            if(activityOption == 3)
                            {
                                DataBase._users.AddingWorkingActivity(DataBase._currentUser.Id);
                            }
                            if(activityOption == 4)
                            {
                                DataBase._users.AddingHobbyActivity(DataBase._currentUser.Id);
                            }
                            if(activityOption == 5)
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                        if(userOption == 4)
                        {
                            Console.Clear();
                            MessageHelper.PrintMessage("Successfully logged out. Press any key to back to login menu...", ConsoleColor.Green);
                            Console.ReadKey();
                            Console.Clear();
                            flag1 = false;
                        }
                    } 
                }
                else
                {
                    DataBase._users.Register(DataBase._currentUser);
                }
            } 
        }
    }
}

