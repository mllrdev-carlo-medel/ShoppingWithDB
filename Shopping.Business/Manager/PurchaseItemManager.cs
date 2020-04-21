using Shopping.Business.Repository;
using Shopping.Business.Model;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;
using System.Collections.Generic;

namespace Shopping.Business.Manager
{
    public class PurchaseItemManager : BaseManager<PurchaseItem>, IPurchaseItemManager
    {
        public override IRepository<PurchaseItem> Repository => new PurchaseItemRepository();

        public bool Add(PurchaseItem purchaseItem)
        {
            return Repository.Add(purchaseItem);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }

        public List<PurchaseItem> GetAll()
        {
            return Repository.GetAll();
        }

        public PurchaseItem GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Update(PurchaseItem purchaseItem)
        {
            return Repository.Update(purchaseItem);
        }
    }
}
