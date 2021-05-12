using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Reading : Track
    {
        public int Pages { get; set; }
        public TrackType.ReadingType ReadingType { get; set; }
        public Reading(int pages, TrackType.ReadingType type)
        {
            Pages = pages;
            Activity = TrackType.Activities.Reading;
            ReadingType = type;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Type: {ReadingType} Pages: {Pages} Time:{Time} \n====");
        }
    }
}
