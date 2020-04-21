using System.Collections.Generic;

namespace Shopping.Business.Repository.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        bool Add(T record);
        T GetById(int id);
        bool Update(T record);
        bool Delete(int id);
    }
}
