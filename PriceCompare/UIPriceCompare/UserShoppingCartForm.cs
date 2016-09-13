using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPriceCompare;
using LogicPriceCompare;

namespace UIPriceCompare
{
    public partial class UserShoppingCartForm : Form
    {
        private User user;
        private ShoppingCart shoppingCart;
        private PriceCompareManager manager;

        public UserShoppingCartForm(User user)
        {
            InitializeComponent();
            this.user = user;
            manager = new PriceCompareManager();
            PopulateUserShoopingCart();
        }

        private void PopulateUserShoopingCart()
        {
            shoppingCart = manager.GetUserShoppingCart(user);
            foreach(var element in shoppingCart.Items)
            {
                ListViewItem listViewItem = new ListViewItem(element.Value.ToString());
                listViewItem.SubItems.Add(element.Key.Id.ToString());
                listViewItem.SubItems.Add(element.Key.Name);
                listViewItem.SubItems.Add(element.Key.Price);
                listViewItem.SubItems.Add(element.Key.Quantity);
                listViewItem.SubItems.Add(element.Key.UnitOfMeasure);
                listViewItem.SubItems.Add(element.Key.Code);
                listViewItem.SubItems.Add(element.Key.Type);
                listViewItem.SubItems.Add(element.Key.StoreId.ToString());
                listViewShoppingCart.Items.Add(listViewItem);
            }
            shoppingCart.CalculateSum();
            labelSumShoppingCart.Text = shoppingCart.Sum.ToString();
        }
    }
}
