using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPriceCompare;

namespace LogicPriceCompare
{
    public class PriceCompareManager
    {
        public User Login(string name, string password)
        {
            if(((!String.IsNullOrEmpty(name)) && (!String.IsNullOrEmpty(password))))
            {
                PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
                List<User> users = dataAccess.GetAllUsers().Where(user => user.Name.Equals(name) && user.Password.Equals(password)).ToList();
                if (users.Count == 1)
                {
                    return users.First();
                }
            }
            return null;
        }

        public User AddUser(string name, string password)
        {
            if (((!String.IsNullOrEmpty(name)) && (!String.IsNullOrEmpty(password))))
            {
                PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
                List<User> users = dataAccess.GetAllUsers().Where(user => user.Name.Equals(name)).ToList();
                if (users.Count == 0)
                {
                    User newUser = new User(name, password);
                    dataAccess.AddUser(newUser);
                    return newUser;
                }
            }
            return null;
        }

        public List<Store> GetAllStores()
        {
            PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
            return dataAccess.GetAllStores();
        }

        public List<Item> GetItemsByStoreId(long storeId)
        {
            PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
            return dataAccess.GetItemsByStoreId(storeId);
        }
    }
}
