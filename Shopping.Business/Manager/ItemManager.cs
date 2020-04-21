using System;
using Shopping.Business.Repository;
using Shopping.Business.Model;
using Shopping.Business.Repository.Interfaces;
using Shopping.Business.Manager.Interfaces;
using System.Collections.Generic;

namespace Shopping.Business.Manager
{
    public class ItemManager : BaseManager<Item>, IItemManager
    {
        public override IRepository<Item> Repository => new ItemRepository();

        public bool Add(Item item)
        {
            return Repository.Add(item);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }

        public List<Item> GetAll()
        {
            return Repository.GetAll();
        }

        public Item GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Update(Item item)
        {
            return Repository.Update(item);
        }
    }
}
