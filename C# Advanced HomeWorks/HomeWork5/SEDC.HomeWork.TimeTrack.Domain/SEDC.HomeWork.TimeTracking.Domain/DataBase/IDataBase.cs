using SEDC.HomeWork.TimeTracking.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Domain.DataBase
{
    public interface IDataBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        T GetByUsernameAndPassword(string username, string password);
        int Insert(T entity);
        void Update(T entity);
    }
}
