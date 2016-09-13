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

namespace UIPriceCompare
{
    public partial class ComparerForm : Form
    {
        ShoppingCart oldShoppingCart;
        List<Store> stores;

        public ComparerForm(ShoppingCart oldShoppingCart, List<Store> stores)
        {
            InitializeComponent();
            this.oldShoppingCart = oldShoppingCart;
            this.stores = stores;
            PopulateShoppingCart(oldShoppingCart, listBoxOldShopingCart, labelOldShoppingCart);
            PopulateStores();
        }

        private void PopulateStores()
        {
            foreach (Store store in stores)
            {
                ListViewItem storeItem = new ListViewItem(store.Id.ToString());
                storeItem.SubItems.Add(store.Name);
                storeItem.SubItems.Add(store.ChainStoreName);
                listViewStores.Items.Add(storeItem);
            }
        }

        private void PopulateShoppingCart(ShoppingCart shoppingCart, ListBox listBox, Label label)
        {
            foreach (var item in shoppingCart.Items)
            {
                listBox.Items.Add(item);
            }
            shoppingCart.CalculateSum();
            label.Text = oldShoppingCart.Sum.ToString();
        }

        private void listViewStores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
