using System;
using Shopping.Business.Repository.Interfaces;

namespace Shopping.Business.Manager
{
    public abstract class BaseManager<T>
    {
        public abstract IRepository<T> Repository { get; }
    }
}
