
using SEDC.HomeWork.TimeTracking.Domain.Modules;


namespace SEDC.HomeWork.TimeTracking.Services.Interfaces
{
    public interface ITrackService<T> where T : Track
    {
        void AddTrack(T track);
        T FindActivityById(int id);
    }
}
