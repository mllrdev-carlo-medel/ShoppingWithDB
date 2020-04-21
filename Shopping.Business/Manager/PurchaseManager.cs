using Shopping.Business.Repository;
using Shopping.Business.Model;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;
using System.Collections.Generic;

namespace Shopping.Business.Manager
{
    public class PurchaseManager : BaseManager<Purchase>, IPurchaseManager
    {
        public override IRepository<Purchase> Repository => new PurchaseRepository();

        public bool Add(Purchase purchase)
        {
            return Repository.Add(purchase);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }

        public List<Purchase> GetAll()
        {
            return Repository.GetAll();
        }

        public Purchase GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Update(Purchase purchase)
        {
            return Repository.Update(purchase);
        }
    }
}
