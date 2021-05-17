using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Exercising : Track
    {
        public Exercising(TrackType.ExercisingType type)
        {
            Activity = TrackType.Activities.Exercising;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Type: {ExercisingType} Time: {Time} seconds \n====");
        }
    }
}
