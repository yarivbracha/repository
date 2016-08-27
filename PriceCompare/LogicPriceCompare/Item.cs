using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPriceCompare
{
    public class Item
    {
        public Item(string name, string price)
        {
            Name = name;
            Price = SetPrice(price);
        }

        private double SetPrice(string price)
        {
            double tempPrice;
            if(Double.TryParse(price, out tempPrice))
            {
                return tempPrice;
            }
            throw new ArgumentException("The Parse of this item price failed!");
        }

        public string Name { get; private set; }

        public double Price { get; private set; }
    }
}
