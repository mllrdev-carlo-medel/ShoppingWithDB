using System;
using System.Collections.Generic;

namespace Shopping.Business.Manager.Interfaces
{
    public interface IManager<T>
    {
        List<T> GetAll();
        bool Add(T data);
        T GetById(int id);
        bool Update(T data);
        bool Delete(int[] id);
    }
}
