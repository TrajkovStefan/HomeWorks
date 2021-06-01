using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Hobbies : Track
    {
        public Hobbies(TrackType.HobbiesType type)
        {
            Activity = TrackType.Activities.Hobbies;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Time: {Time} seconds \n====");
        }
    }
}
