using System;
using System.Collections.Generic;
using System.IO;
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

        public ShoppingCart CompareShoppingCart(long storeId, ShoppingCart oldShoppingCart)
        {
            ShoppingCart newShoppingCart = new ShoppingCart(storeId);
            List<Item> items = GetItemsByStoreId(storeId);
            foreach (var item in oldShoppingCart.Items)
            {
                if (item.Key.Type == "1")
                {
                    var tempList = items.Where(newItem => newItem.Code == item.Key.Code).ToList();
                    if ((tempList != null) && (tempList.Count == 1))
                    {
                        newShoppingCart.AddItem(tempList[0], item.Value);
                    }
                }
                else
                {
                    var tempList = items.Where(newItem => newItem.Name == item.Key.Name).ToList();
                    if ((tempList != null) && (tempList.Count == 1))
                    {
                        newShoppingCart.AddItem(tempList[0], item.Value);
                    }
                }
            }
            return newShoppingCart;
        }

        public void SaveShoppingCartToTheUser(User user, ShoppingCart shoppingCart)
        {
            StreamWriter file = new StreamWriter(user.FileName);
            StringBuilder sb = new StringBuilder();
            foreach (var element in shoppingCart.Items)
            {
                sb.Append(element.Value + ",");
                sb.Append(element.Key.Id + ",");
                sb.Append(element.Key.Name + ",");
                sb.Append(element.Key.Price + ",");
                sb.Append(element.Key.Code + ",");
                sb.Append(element.Key.Type + ",");
                sb.Append(element.Key.Quantity + ",");
                sb.Append(element.Key.UnitOfMeasure + ",");
                sb.Append(element.Key.StoreId);
                sb.Append("\n");
            }
            file.Write(sb.ToString());
            file.Close();
        }
    }
}
