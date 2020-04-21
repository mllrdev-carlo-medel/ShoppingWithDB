using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Model;
using Shopping.Business.Helper;
using Shopping.Business.Repository.Interfaces;

namespace Shopping.Business.Repository
{
    public class PurchaseItemRepository : BaseRepository<PurchaseItem>, IPurchaseItemRepository
    {
        public override IDbConnection DbConnection => new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]);

        public List<PurchaseItem> GetAll()
        {
            return DbConnection.Query<PurchaseItem>("SELECT * FROM PurchaseItem").ToList();
        }

        public bool Add(PurchaseItem purchaseItem)
        {
            try
            {
                string sqlQuery = "Insert Into PurchaseItem (PurchaseId, ItemId, Quantity, Subtotal) " +
                                  "Values(@PurchaseId, @ItemId, @Quantity, @Subtotal)";

                int rowsAffected = DbConnection.Execute(sqlQuery, purchaseItem);
                return rowsAffected > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PurchaseItem GetById(int id)
        {
            return DbConnection.Query<PurchaseItem>("SELECT * FROM PurchaseItem WHERE Id=@Id", new { Id = id }).SingleOrDefault();
        }

        public bool Update(PurchaseItem purchaseItem)
        {
            string query = "UPDATE PurchaseItem SET Quantity = @Quantity, Subtotal = @Subtotal WHERE PurchaseId = @PurchaseId";

            int count = this.DbConnection.Execute(query, purchaseItem);
            return count == 1 ? true : false;
        }

        public bool Delete(int id)
        {
            int count = DbConnection.Execute("DELETE FROM PurchaseItem WHERE PurchaseId = @Id", new { Id = id });
            return count == 1 ? true : false;
        }
    }
}
