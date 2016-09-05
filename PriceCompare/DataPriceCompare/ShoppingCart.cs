using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    class ShoppingCart
    {
        public ShoppingCart(Dictionary<Item,int> items)
        {
            Items = items;
            CalculateSum();
        }

        private void CalculateSum()
        {
            Sum = 0;
            foreach(var element in Items)
            {
                Sum += element.Key.Price * element.Value;
            }
        }

        public Dictionary<Item,int> Items { get; private set; }

        public double Sum { get; private set; }
    }
}
