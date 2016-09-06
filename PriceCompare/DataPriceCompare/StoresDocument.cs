using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class StoresDocument
    {
        public StoresDocument(string chainStoresName)
        {
            ChainStoresName = chainStoresName;
        }

        public string ChainStoresName { get; private set; }

        public Dictionary<string, string> Stores { get; private set; }

        public void AddStore(string id, string name)
        {
            Stores.Add(id, name);
        }
    }
}
