using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPriceCompare;

namespace LogicPriceCompare
{
    public class PriceCompareDataAccess
    {
        public void AddItem(Item item)
        {
            PriceCompareContext db = new PriceCompareContext();
            db.Items.Add(item);
        }

        public void AddStore(Store store)
        {
            PriceCompareContext db = new PriceCompareContext();
            db.Stores.Add(store);
        }

        public List<Item> GetAllItems()
        {
            PriceCompareContext db = new PriceCompareContext();
            return db.Items.ToList();
        }

        public List<Store> GetAllStores()
        {
            PriceCompareContext db = new PriceCompareContext();
            return db.Stores.ToList();
        }

        public List<Store> GetStoresByChainStoreId(string chainStoresId)
        {
            PriceCompareContext db = new PriceCompareContext();
            return db.Stores.Where(store => store.ChainStoreID.Equals(chainStoresId)).ToList();
        }

        public List<Item> GetItemsByStoreId(long id)
        {
            PriceCompareContext db = new PriceCompareContext();
            return db.Items.Where(item => item.StoreID == id).ToList();
        }
    }
}
