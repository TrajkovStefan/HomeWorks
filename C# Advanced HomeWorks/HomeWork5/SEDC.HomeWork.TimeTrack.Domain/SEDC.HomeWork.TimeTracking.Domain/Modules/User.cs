﻿using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
        public TrackType.ExercisingType ExercisingType { get; set; }
        public TrackType.ReadingType ReadingType { get; set; }
        public TrackType.WorkingType WorkingType { get; set; }
        public double Time { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} has {Age} years old. \nUsername: {Username} \nPassword: {Password}"); 
            if(ReadingType == TrackType.ReadingType.Belles_Lettres)
            {
                Console.WriteLine($"Activity: Reading - Type: {TrackType.ReadingType.Belles_Lettres} - Time: {Time} seconds");
            }
            if (ReadingType == TrackType.ReadingType.Fiction)
            {
                Console.WriteLine($"Activity: Reading - Type: {TrackType.ReadingType.Fiction} - Time: {Time} seconds");
            }
            if (ReadingType == TrackType.ReadingType.Professional_Literature)
            {
                Console.WriteLine($"Activity: Reading - Type: {TrackType.ReadingType.Professional_Literature} - Time: {Time} seconds");
            }
            if(ExercisingType == TrackType.ExercisingType.General)
            {
                Console.WriteLine($"Activity: Exercising - Type: {TrackType.ExercisingType.General} - Time: {Time} seconds");
            }
            if (ExercisingType == TrackType.ExercisingType.Running)
            {
                Console.WriteLine($"Activity: Exercising - Type: {TrackType.ExercisingType.Running} - Time: {Time} seconds");
            }
            if (ExercisingType == TrackType.ExercisingType.Sport)
            {
                Console.WriteLine($"Activity: Exercising - Type: {TrackType.ExercisingType.Sport} - Time: {Time} seconds");
            }
            if(WorkingType == TrackType.WorkingType.Home)
            {
                Console.WriteLine($"Activity: Working - Type: {TrackType.WorkingType.Home} - Time {Time} seconds");
            }
            if (WorkingType == TrackType.WorkingType.Office)
            {
                Console.WriteLine($"Activity: Working - Type: {TrackType.WorkingType.Office} - Time {Time} seconds");
            }
        }
    }
}
