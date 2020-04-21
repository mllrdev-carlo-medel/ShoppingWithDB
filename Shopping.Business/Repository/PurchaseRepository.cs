using System.Collections.Generic;
using Shopping.Business.Repository.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Model;
using System;
using System.Configuration;

namespace Shopping.Business.Repository
{
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        public override IDbConnection DbConnection => new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]);

        public List<Purchase> GetAll()
        {
            return DbConnection.Query<Purchase>("SELECT * FROM Purchase").ToList();
        }

        public bool Add(Purchase Purchase)
        {
            try
            {
                string query = "Insert Into Purchase (Id, CustomerId, Status, Date, Total) " +
                                  "Values(@Id, @CustomerId, @Status, @Date, @Total)";

                int count = DbConnection.Execute(query, Purchase);
                return count == 1 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Purchase GetById(int id)
        {
            return DbConnection.Query<Purchase>("SELECT * FROM Purchase WHERE Id = @Id", new { Id = id }).SingleOrDefault();
        }

        public bool Update(Purchase Purchase)
        {
            string query = "UPDATE Purchase SET Status = @Status, Date = @Date, Total = @Total WHERE Id = @Id";

            int count = this.DbConnection.Execute(query, Purchase);
            return count == 1 ? true : false;
        }

        public bool Delete(int id)
        {
            int count = DbConnection.Execute("DELETE FROM Purchase WHERE PurchaseId = @Id", new { Id = id });
            return count == 1 ? true : false;
        }
    }
}
