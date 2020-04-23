using Shopping.Business.Repository;
using Shopping.Business.Entity;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;

namespace Shopping.Business.Manager
{
    public class PurchaseManager : BaseManager<Purchase>, IPurchaseManager
    {
        public override IRepository<Purchase> Repository => new PurchaseRepository();
    }
}
