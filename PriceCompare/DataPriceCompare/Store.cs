using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class Store
    {
        private Dictionary<string, Item> items;

        public Store() { }

        public Store(string name)
        {
            Name = name;
           // items = new Dictionary<string, Item>();
        }

        public Dictionary<string, Item> Items
        {
            get { return items; }
        }

        public bool AddItem(Item item)
        {
            bool isAddItem = false;
            if (item != null)
            {
                if (!items.ContainsKey(item.Name))
                {
                    items.Add(item.Name, item);
                    isAddItem = true;
                }
            }
            return isAddItem;
        }

        public long Id { get; set; }

        public string Name { get; set; }

       // public string StoreId { get; set; }

        public string ChainStoreName { get; set; }
    }
}
