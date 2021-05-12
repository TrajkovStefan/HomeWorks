using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Interfaces;
using System;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Working : Track, IWorking
    {
        public void AddTypes()
        {
            WorkingType.Add(TrackType.WorkingType.Home);
            WorkingType.Add(TrackType.WorkingType.Office);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Title} - {Description}");
        }

        public void PrintTypes()
        {
            foreach(TrackType.WorkingType type in WorkingType)
            {
                Console.WriteLine(type);
            }
        }
    }
}
