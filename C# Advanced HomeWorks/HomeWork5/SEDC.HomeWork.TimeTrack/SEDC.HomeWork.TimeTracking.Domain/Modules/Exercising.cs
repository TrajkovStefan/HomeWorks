using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Exercising : Track
    {
        public TrackType.ExercisingType Type { get; set; }
        public Exercising(TrackType.ExercisingType type)
        {
            Activity = TrackType.Activities.Exercising;
            Type = type;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Type: {Type} Time: {Time} seconds \n====");
        }
    }
}
