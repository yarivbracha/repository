using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPriceCompare
{
    public class ChainStore
    {
        private Dictionary<string,Store> stores;
        public ChainStore(string name)
        {
            Name = name;
            stores = new Dictionary<string, Store>();
        }

        public string Name { get; private set; }

        public Dictionary<string, Store> Stores
        {
            get { return stores; }
        }

        public bool AddStore(Store store)
        {
            bool isAddedStore = false;
            if(store != null)
            {
                if(!Stores.ContainsKey(store.Name))
                {
                    Stores.Add(store.Name, store);
                    isAddedStore = true;
                }
            }
            return isAddedStore;
        }
    }
}
