using System;
using Shopping.Business.Repository;
using Shopping.Business.Entity;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;

namespace Shopping.Business.Manager
{
    public class ItemManager : BaseManager<Item>, IItemManager
    {
        public override IRepository<Item> Repository => new ItemRepository();
    }
}
