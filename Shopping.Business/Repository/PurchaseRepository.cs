using System.Collections.Generic;
using Shopping.Business.Repository.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Entity;
using System;
using System.Configuration;

namespace Shopping.Business.Repository
{
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        public override string Table => "Purchase";
    }
}
