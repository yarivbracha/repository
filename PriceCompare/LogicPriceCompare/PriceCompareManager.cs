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
                sb.Append(element.Key.Quantity + ",");
                sb.Append(element.Key.UnitOfMeasure + ",");
                sb.Append(element.Key.Code + ",");
                sb.Append(element.Key.Type + ",");
                sb.Append(element.Key.StoreId);
                sb.Append("\n");
            }
            file.Write(sb.ToString());
            file.Close();
        }

        public ShoppingCart GetUserShoppingCart(User user)
        {
            ShoppingCart shoppingCart = new ShoppingCart(-1);
            string[] lines = File.ReadAllLines(user.FileName);
            if(lines != null)
            {
                foreach(string line in lines)
                {
                    string[] itemDetails = line.Split(',');
                    Item item = new Item();
                    int amount = int.Parse(itemDetails[0]);
                    item.Id = long.Parse(itemDetails[1]);
                    item.Name = itemDetails[2];
                    item.Price = itemDetails[3];
                    item.Quantity = itemDetails[4];
                    item.UnitOfMeasure = itemDetails[5];
                    item.Code = itemDetails[6];
                    item.Type = itemDetails[7];
                    item.StoreId = long.Parse(itemDetails[8]);
                    shoppingCart.AddItem(item, amount);
                }
                return shoppingCart;
            }
            return null;
        }
    }
}
