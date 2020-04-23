using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Entity;
using Shopping.Business.Repository.Interfaces;

namespace Shopping.Business.Repository
{
    public class PurchaseItemRepository : BaseRepository<PurchaseItem>, IPurchaseItemRepository
    {
        public override string Table => "PurchaseItem";
    }
}
