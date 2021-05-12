using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Interfaces;
using System;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Reading : Track, IReading
    {
        public int Pages { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"{Title} - {Description}"); 
        }

        public void AddTypes()
        {
            ReadingType.Add(TrackType.ReadingType.Belles_Lettres);
            ReadingType.Add(TrackType.ReadingType.Fiction);
            ReadingType.Add(TrackType.ReadingType.Professional_Literature);
        }

        public void PrintTypes()
        {
            foreach (TrackType.ReadingType type in ReadingType)
            {
                Console.WriteLine(type);
            }
        }
    }
}
