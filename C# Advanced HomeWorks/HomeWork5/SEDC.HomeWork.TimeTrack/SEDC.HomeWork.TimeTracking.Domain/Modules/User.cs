﻿using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserAccStatus Status { get; set; }
        public List<Track> ListOfActivities { get; set; }
        public int TimeExercising { get; set; }
        public int TimeReading { get; set; }
        public int TimeWorking { get; set; }
        public User()
        {
            ListOfActivities = new List<Track>();
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} \nusername: {Username} password:{Password}");
            foreach (var type in ListOfActivities)
            {
                type.GetInfo();
            }
        }
    }
}
