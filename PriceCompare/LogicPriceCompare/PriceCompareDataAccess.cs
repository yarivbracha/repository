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
            PriceCompareContext db = PriceCompareContext.Instance;
            db.Items.Add(item);
            db.SaveChanges();
        }

        public void AddItems(List<Item> items)
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            foreach (Item item in items)
            {
                db.Items.Add(item);
            }
            db.SaveChanges();
        }

        public void AddStore(Store store)
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            db.Stores.Add(store);
            db.SaveChanges();
        }

        public void AddUser(User user)
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            if(String.IsNullOrEmpty(user.Name) || String.IsNullOrEmpty(user.Password))
            {
                throw new ArgumentException("Please enter name and password!");
            }
            if (db.Users.Where(dbUser => dbUser.Name == user.Name).ToList().Count != 0)
            {
                throw new ArgumentException($"There is user with the name {user.Name}!"); 
            }
            db.Users.Add(user);
            db.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            return db.Items.ToList();
        }

        public List<Store> GetAllStores()
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            return db.Stores.ToList();
        }

        public List<User> GetAllUsers()
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            return db.Users.ToList();
        }

        public List<Store> GetStoresByChainStoreId(string chainStoresName)
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            return db.Stores.Where(store => store.ChainStoreName.Equals(chainStoresName)).ToList();
        }

        public List<Item> GetItemsByStoreId(long id)
        {
            PriceCompareContext db = PriceCompareContext.Instance;
            return db.Items.Where(item => item.StoreId == id).ToList();
        }

        //public long GetStoreId(Store store)
        //{
        //    PriceCompareContext db = new PriceCompareContext();
        //    List<Store> stores = db.Stores.Where(currentStore => currentStore.Name.Equals(store.Name) && currentStore.ChainStoreName.Equals(store.ChainStoreName)).ToList();
        //    if(stores.Count == 1)
        //    {
        //        return stores[0].Id;
        //    }
        //    return -1;
        //}
    }
}
