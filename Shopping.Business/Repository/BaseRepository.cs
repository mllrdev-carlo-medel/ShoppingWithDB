using System;
using System.Collections.Generic;
using System.Data;

namespace Shopping.Business.Repository
{
    public abstract class BaseRepository<T>
    {
        public abstract IDbConnection DbConnection { get; }

    }
}
