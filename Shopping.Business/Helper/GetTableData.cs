using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Shopping.Business.Model;

namespace Shopping.Business.Helper
{
    public static class GetTableData<T>
    {
        public static List<T> GetByName(string name)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]))
            {
               return db.Query<T>("Select * From " + name).ToList();
            }
        }

        public static List<T> GetByNameWithCondition(string name, string condition)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["GroceryDB"]))
            {
                return db.Query<T>("Select * From " + name + " Where " + condition).ToList();
            }
        }
    }
}
