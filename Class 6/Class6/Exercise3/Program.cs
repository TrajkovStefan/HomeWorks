using Exercise3.Modules;
using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User(5, "stefan", 12345, new string[] {"hello", "bye", "good"}),
                new User(3, "bojan", 34214, new string[]{"hi", "sedc", "academy" }),
                new User(2, "marko", 654123, new string[]{"no", "yes", "maybe" }),
            };


            Console.WriteLine("Enter the option 1 / 2");
            bool success = int.TryParse(Console.ReadLine(), out int input);
            if (input == 1)
            {
                Console.WriteLine("LOG IN");
                Console.WriteLine("Enter the username and password");
                string username = Console.ReadLine();
                bool success2 = int.TryParse(Console.ReadLine(), out int pass);
                if (success2)
                {
                    bool userFound = false;
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (username.ToLower() == users[i].Username.ToLower() && pass == users[i].Passwrod)
                        {
                            foreach (string mess in users[i].Messages)
                            {
                                Console.WriteLine(mess);
                            }
                            userFound = true;
                            break;
                        }
                    }
                    if (!userFound)
                    {
                        Console.WriteLine("User cant be founded");
                    }
                }
                else
                {
                    Console.WriteLine("Cant parsed input");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("REGISTER");
                Console.WriteLine("Enter ID, Username and password");
                bool successId = int.TryParse(Console.ReadLine(), out int idUser);
                string username2 = Console.ReadLine();
                bool successPass = int.TryParse(Console.ReadLine(), out int passUser);
                if (successId && successPass)
                {
                    bool userFound = false;
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (username2 == users[i].Username)
                        {
                            userFound = true;
                            Console.WriteLine("We have that user");
                            break;
                        }
                    }
                    if (userFound == false)
                    {
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = new User(idUser, username2, passUser);
                        foreach (User user in users)
                        {
                            Console.WriteLine(user.Username);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
