using Rock_Paper_Scissors.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors.Domain
{
    public static class AppDb
    {
        public static List<User> Users = new List<User>
        {
            new User() {Username = "user1", Password = "1234" , FirstName = "Stefan" , Lastname = "Stefanovski"},
            new User() {Username = "user2", Password = "4321" , FirstName = "Petar" , Lastname = "Petrovski"},
            new User() {Username = "user3", Password = "2132" , FirstName = "Nikola" , Lastname = "Nikolovski"},
        };
    }
}
