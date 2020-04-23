using Shopping.Business.Repository;
using Shopping.Business.Entity;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;

namespace Shopping.Business.Manager
{
    public class PurchaseItemManager : BaseManager<PurchaseItem>, IPurchaseItemManager
    {
        public override IRepository<PurchaseItem> Repository => new PurchaseItemRepository();
    }
}
