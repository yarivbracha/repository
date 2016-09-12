using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class ShoppingCart
    {
        public ShoppingCart(long storeId)
        {
            StoreId = storeId;
            Items = new Dictionary<Item, int>();
        }

        public void CalculateSum()
        {
            Sum = 0;
            foreach(var element in Items)
            {
                Sum += Double.Parse(element.Key.Price)  * element.Value;
            }
        }

        public void AddItem(Item item, int itemsSum)
        {
            if (itemsSum > 0)
            {
                if (Items != null)
                {
                    if (Items.Keys.Where(it => it.Id == item.Id).ToList().Count == 0)
                    {
                        Items.Add(item, itemsSum);
                    }
                    else
                    {
                        throw new ArgumentException("This item is already in the shoping cart!!");
                    }
                }
            }
 
        }

        public Dictionary<Item, int> Items { get; private set; }

        public double Sum { get; private set; }

        public long StoreId { get; set; } 
    }
}
