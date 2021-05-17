using SEDC.HomeWork.TimeTracking.Domain.Enums;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public abstract class Track : BaseEntity
    {
        public double Time { get; set; }
        public TrackType.ReadingType ReadingType { get; set; }
        public TrackType.ExercisingType ExercisingType { get; set; }
        public TrackType.WorkingType WorkingType { get; set; }
        public TrackType.HobbiesType HobbiesType { get; set; }
        public TrackType.Activities Activity { get; set; }
    }
}
