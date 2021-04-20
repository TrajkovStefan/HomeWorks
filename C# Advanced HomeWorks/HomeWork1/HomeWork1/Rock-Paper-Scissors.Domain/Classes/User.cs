using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors.Domain.Classes
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Wins { get; set; }
    }
}
