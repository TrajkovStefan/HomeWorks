using Rock_Paper_Scissors.Domain;
using Rock_Paper_Scissors.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rock_Paper_Scissors.Services
{
    public class UserService
    {
        public User GetStudentByUserName(string username)
        {
            return AppDb.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public User UserLogin(string username)
        {
            User user = GetStudentByUserName(username);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public bool PasswordsMatch(string password)
        {
            Console.WriteLine("Enter the password");
            string userPassword = Console.ReadLine();
            if (password == userPassword)
            {
                return true;
            }
            return false;
        }
    }
}
