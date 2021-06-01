using SEDC.HomeWork.TimeTracking.Domain.DataBase;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;


namespace SEDC.HomeWork.TimeTracking.Services.Implementations
{
    public class TrackService<T> : ITrackService<T> where T : Track
    {
        private IDataBase<T> _dataBase;
        public TrackService()
        {
            //_dataBase = new DataBase<T>(); - in memory db (list)
            _dataBase = new FileDataBase<T>();
        }

        public void AddTrack(T track)
        {
            _dataBase.Insert(track);
        }
        public T FindActivityById(int id)
        {
            T activity = _dataBase.GetById(id);
            return activity;
        }
    }
}
