using SEDC.HomeWork.TimeTracking.Domain.Enums;


namespace SEDC.HomeWork.TimeTracking.Domain.Modules
{
    public abstract class Track : BaseEntity
    {
        public double Time { get; set; }
        public TrackType.Activities Activity { get; set; }
    }
}
