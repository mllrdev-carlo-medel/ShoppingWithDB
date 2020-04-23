using System;
using System.Collections.Generic;
using Shopping.Business.Repository.Interfaces;

namespace Shopping.Business.Manager
{
    public abstract class BaseManager<T>
    {
        public abstract IRepository<T> Repository { get; }

        public bool Add(T data)
        {
            return Repository.Add(data);
        }

        public bool Delete(int[] id)
        {
            return Repository.Delete(id);
        }

        public List<T> GetAll()
        {
            return Repository.GetAll();
        }

        public T GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Update(T data)
        {
            return Repository.Update(data);
        }
    }
}
