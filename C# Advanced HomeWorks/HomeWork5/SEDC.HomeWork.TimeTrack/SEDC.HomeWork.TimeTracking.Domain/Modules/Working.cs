using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Working : Track
    {
        public TrackType.WorkingType Type { get; set; }
        public Working(TrackType.WorkingType type)
        {
            Activity = TrackType.Activities.Working;
            Type = type;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Type: {Type} Time: {Time} seconds \n====");
        }
    }
}
