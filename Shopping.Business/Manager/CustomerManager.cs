using System;
using Shopping.Business.Repository;
using Shopping.Business.Entity;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;

namespace Shopping.Business.Manager
{
    public class CustomerManager : BaseManager<Customer>, ICustomerManager
    {
        public override IRepository<Customer> Repository => new CustomerRepository();
    }
}
