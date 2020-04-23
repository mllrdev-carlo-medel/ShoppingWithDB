using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Entity;


namespace Shopping.Business.Repository
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public override string Table => "Item";
    }
}
