using SEDC.HomeWork.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public abstract class Track : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Time { get; set; }
        public List<TrackType.ExercisingType> ExercisingType { get; set; }
        public List<TrackType.ReadingType> ReadingType { get; set; }
        public List<TrackType.WorkingType> WorkingType { get; set; }

        public Track()
        {
            ExercisingType = new List<TrackType.ExercisingType>();
            ReadingType = new List<TrackType.ReadingType>();
            WorkingType = new List<TrackType.WorkingType>();
        }

    }
}
