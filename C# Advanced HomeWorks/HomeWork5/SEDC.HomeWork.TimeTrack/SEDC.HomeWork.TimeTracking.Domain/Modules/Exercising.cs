using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Interfaces;
using System;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public class Exercising : Track, IExercising
    {
        public void AddTypes()
        {
            ExercisingType.Add(TrackType.ExercisingType.General);
            ExercisingType.Add(TrackType.ExercisingType.Running);
            ExercisingType.Add(TrackType.ExercisingType.Sport);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Title} {Description}"); 
        }

        public void PrintTypes()
        {
            foreach(TrackType.ExercisingType type in ExercisingType)
            {
                Console.WriteLine(type);
            }
        }
    }
}
