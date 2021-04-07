using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Modules
{
   public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Passwrod { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string username, int password, string[] messages)
        {
            Id = id;
            Username = username;
            Passwrod = password;
            Messages = messages;
        }
        public User(int id, string username, int password)
        {
            Id = id;
            Username = username;
            Passwrod = password;
        }

    }
}
