using System.Collections.Generic;

namespace Shopping.Business.Repository.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        bool Add(T data);
        T GetById(int id);
        bool Update(T data);
        bool Delete(int[] id);
    }
}
