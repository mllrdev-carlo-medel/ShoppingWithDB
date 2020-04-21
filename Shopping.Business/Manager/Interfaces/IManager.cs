using System;
using System.Collections.Generic;

namespace Shopping.Business.Manager.Interfaces
{
    public interface IManager<T>
    {
        List<T> GetAll();
        bool Add(T record);
        T GetById(int id);
        bool Update(T record);
        bool Delete(int id);
    }
}
