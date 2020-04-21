using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Model;


namespace Shopping.Business.Repository
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public override IDbConnection DbConnection => new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]);

        public List<Item> GetAll()
        {
            return DbConnection.Query<Item>("SELECT * FROM Item").ToList();
        }

        public bool Add(Item item)
        {
            try
            {
                string query = "Insert Into Item (Id, Name, Price) " +
                                  "Values(@Id, @Name, @Price)";

                int count = DbConnection.Execute(query, item);
                return count == 1 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Item GetById(int id)
        {
            return DbConnection.Query<Item>("SELECT * FROM Item WHERE Id=@Id", new { Id = id }).SingleOrDefault();
        }

        public bool Update(Item item)
        {
            string query = "UPDATE Item SET Name = @Name, Price = @Price WHERE Id = @Id";

            int count = this.DbConnection.Execute(query, item);
            return count == 1 ? true : false;
        }

        public bool Delete(int id)
        {
            int count = DbConnection.Execute("DELETE FROM Item WHERE Id = @Id", new { Id = id });
            return count == 1 ? true : false;
        }
    }
}
