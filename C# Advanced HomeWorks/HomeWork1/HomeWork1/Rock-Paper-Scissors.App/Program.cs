using Rock_Paper_Scissors.Domain.Classes;
using Rock_Paper_Scissors.Services;
using System;

namespace Rock_Paper_Scissors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            MenuService menuservice = new MenuService();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    if (string.IsNullOrEmpty(username))
                    {
                        throw new Exception("You must enter username");
                    }

                    User user = userService.GetStudentByUserName(username);
                    Computer computer = new Computer();
                    if (user == null)
                    {
                        throw new Exception("The user does not exist");
                    }

                    bool passwordsMatch = userService.PasswordsMatch(user.Password);
                    if (!passwordsMatch)
                    {
                        throw new Exception("Password did not match");
                    }

                    while (true)
                    {
                        Console.WriteLine("Enter the option 1)Play 2)Stats 3)Exit");
                        bool success = int.TryParse(Console.ReadLine(), out int answer);
                        if (success)
                        {
                            if (answer == 1)
                            {
                                menuservice.Play(user, computer);
                            }
                            else if (answer == 2)
                            {
                                menuservice.Stats(user, computer);
                            }
                            else if (answer == 3)
                            {
                                menuservice.Exit();
                            }
                            else
                            {
                                throw new Exception("Wrong option");
                            }
                        }
                        Console.WriteLine("Press enter to back to main menu");
                        Console.ReadLine();
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("User does not exist");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Incorrect input");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("An error occured");
                }
           
            Console.WriteLine("Do you want try again? yes/no");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                flag = true;
            }
            else
            {
                flag = false;
                Console.WriteLine("Goodbye");
            }
            }
            Console.ReadLine();
        }
    }
}
