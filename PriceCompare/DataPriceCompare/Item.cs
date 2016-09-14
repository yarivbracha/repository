using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class Item : IDBItem
    {
        public Item() { }

        public Item(string name)
        {
            Name = name;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Code { get; set; }

        public string Type { get; set; }

        public string Quantity { get; set; }

        public string UnitOfMeasure { get; set; }

        public long StoreId { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
