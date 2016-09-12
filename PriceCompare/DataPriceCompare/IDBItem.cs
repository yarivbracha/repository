using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    interface IDBItem
    {
        long Id { get; set; }

        string Name { get; set; }
    }
}
