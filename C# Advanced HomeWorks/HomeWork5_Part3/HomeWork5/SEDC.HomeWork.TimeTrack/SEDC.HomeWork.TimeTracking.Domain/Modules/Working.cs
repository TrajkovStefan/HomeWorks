using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Working : Track
    {
        public double WorkingHoursFromOffice { get; set; }
        public double WorkingHoursFromHome{ get; set; }
        public Working(TrackType.WorkingType type)
        {
            Activity = TrackType.Activities.Working;
            WorkingHoursFromOffice = 0;
            WorkingHoursFromHome = 0;
    }

        public override void GetInfo()
        {
            Console.WriteLine($"Activity: {Activity} Time: {Time} seconds \n====");
        }
    }
}
