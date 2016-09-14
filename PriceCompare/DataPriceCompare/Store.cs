using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class Store : IDBItem
    { 

        public Store() { }

        public Store(string name)
        {
            Name = name;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string ChainStoreName { get; set; }
    }
}
