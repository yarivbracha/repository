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
            using (PriceCompareContext db = new PriceCompareContext())
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

        public void DeleteAll()
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                //db.Database.ExecuteSqlCommand("delete from PriceCompare");
                //foreach (var entity in db.Items)
                //{
                    db.Items.RemoveRange(db.Items);
                //}
                //foreach (var entity in db.Users)
                //{
                    db.Users.RemoveRange(db.Users);
                //}
                //foreach (var entity in db.Stores)
                //{
                    db.Stores.RemoveRange(db.Stores);
                //}
                db.SaveChanges();
                var i = db.Items.ToList();
                var s = db.Stores.ToList();
                var u = db.Users.ToList();
            }
        }

        public void AddItems(List<Item> items)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                db.Items.AddRange(items);
                db.SaveChanges();
            }
        }

        public void AddStore(Store store)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                if (db.Stores.Where(dbStore => dbStore.Name.Equals(store.Name) && dbStore.ChainStoreName.Equals(store.ChainStoreName)).ToList().Count == 0)
                {
                    db.Stores.Add(store);
                    db.SaveChanges();
                }
            }
        }

        public void AddUser(User user)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
               if (String.IsNullOrEmpty(user.Name) || String.IsNullOrEmpty(user.Password))
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
        }

        public List<Item> GetAllItems()
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                return db.Items.ToList();
            }
        }

        public List<Store> GetAllStores()
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                return db.Stores.ToList();
            }
        }

        public List<User> GetAllUsers()
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                return db.Users.ToList();
            }
        }

        public List<Store> GetStoresByChainStoreId(string chainStoresName)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                return db.Stores.Where(store => store.ChainStoreName.Equals(chainStoresName)).ToList();
            }
        }

        public List<Item> GetItemsByStoreId(long id)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                return db.Items.Where(item => item.StoreId == id).ToList();
            }
        }

        public long GetStoreId(Store store)
        {
            using (PriceCompareContext db = new PriceCompareContext())
            {
                List<Store> stores = db.Stores.Where(currentStore => currentStore.Name.Equals(store.Name) && currentStore.ChainStoreName.Equals(store.ChainStoreName)).ToList();
                if (stores.Count == 1)
                {
                    return stores[0].Id;
                }
                return -1;
            }
        }


    }
}
