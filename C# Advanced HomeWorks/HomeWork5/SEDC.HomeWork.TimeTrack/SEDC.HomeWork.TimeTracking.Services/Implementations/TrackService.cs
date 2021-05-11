using SEDC.HomeWork.TimeTracking.Domain.DataBase;
using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Services.Implementations
{
    public class TrackService<T> : ITrackService<T> where T : Track
    {
        private IDataBase<T> _database;
        public TrackService()
        {
            _database = new DataBase<T>();
        }

        public void AddTrack(T track)
        {
            _database.Insert(track);
        }

    }
}
