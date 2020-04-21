using System;
using Shopping.Business.Repository;
using Shopping.Business.Model;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;
using System.Collections.Generic;

namespace Shopping.Business.Manager
{
    public class CustomerManager : BaseManager<Customer>, ICustomerManager
    {
        public override IRepository<Customer> Repository => new CustomerRepository();

        public bool Add(Customer customer)
        {
            return Repository.Add(customer);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return Repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Update(Customer customer)
        {
            return Repository.Update(customer);
        }
    }
}
