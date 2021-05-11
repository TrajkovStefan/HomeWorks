using SEDC.HomeWork.TimeTracking.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Domain.DataBase
{
    public class DataBase<T> : IDataBase<T> where T : BaseEntity
    {
        private List<T> _tableList { get; set; }
        public int Id { get; set; }
        public DataBase()
        {
            _tableList = new List<T>();
            Id = 1;
        }
        public List<T> GetAll()
        {
            return _tableList;
        }

        public T GetById(int id)
        {
            T dbEntity = _tableList.FirstOrDefault(x => x.Id == id);
            if(dbEntity == null)
            {
                throw new Exception($"Entity with id {id} not found");
            }
            return dbEntity;
        }

        public int Insert(T entity)
        {
            entity.Id = Id++;
            _tableList.Add(entity);
            return entity.Id;
        }

        public void Update(T entity)
        {
            T dbEntity = _tableList.FirstOrDefault(x => x.Id == entity.Id);
            if (dbEntity == null)
            {
                throw new Exception($"Entity with id {entity.Id} not found");
            }
            dbEntity = entity;
        }

        public T GetByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
