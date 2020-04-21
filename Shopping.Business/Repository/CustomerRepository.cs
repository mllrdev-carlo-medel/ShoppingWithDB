using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Model;

using Shopping.Business.Repository.Interfaces;

namespace Shopping.Business.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public override IDbConnection DbConnection => new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]);


        public List<Customer> GetAll()
        {
            return DbConnection.Query<Customer>("SELECT * FROM Customer").ToList();
        }

        public bool Add(Customer customer)
        {
            try
            { 
                string query = "Insert Into Customer (Id, FirstName, MiddleName, LastName, Gender, ContactNo, Email, Address) " +
                                  "Values(@Id, @FirstName, @MiddleName, @LastName, @Gender, @ContactNo, @Email, @Address)";

                int count = DbConnection.Execute(query, customer);
                return count == 1 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Customer GetById(int id)
        {
            return DbConnection.Query<Customer>("SELECT * FROM Customer WHERE Id=@Id", new { Id = id }).SingleOrDefault();
        }

        public bool Update(Customer customer)
        {
            string query = "UPDATE Customer SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName," +
                           "Gender = @Gender, ContactNo = @ContactNo, Email = @Email, Address = @Address " +
                           "WHERE Id = @Id";

            int count = DbConnection.Execute(query, customer);
            return count == 1 ? true : false;
        }

        public bool Delete(int id)
        {
            int count = DbConnection.Execute("DELETE FROM Customer WHERE ID = @Id", new { Id = id });
            return count == 1 ? true : false;
        }
    }
}
