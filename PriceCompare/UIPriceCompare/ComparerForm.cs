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
    public partial class ComparerForm : Form
    {
        ShoppingCart oldShoppingCart;
        ShoppingCart newShoppingCart;
        List<Store> stores;
        PriceCompareManager manager;

        public ComparerForm(ShoppingCart oldShoppingCart, List<Store> stores)
        {
            InitializeComponent();
            this.oldShoppingCart = oldShoppingCart;
            this.stores = stores;
            manager = new PriceCompareManager();
            PopulateNewShoppingCart(oldShoppingCart, listViewOldShoppingCart, labelOldShoppingCart);
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
            if (listViewStores.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = listViewStores.SelectedItems[0];
            newShoppingCart = manager.CompareShoppingCart(long.Parse(item.Text), oldShoppingCart);
            PopulateNewShoppingCart(newShoppingCart, listViewNewShoppingCart, labelNewShopingCart);
        }

        private void PopulateNewShoppingCart(ShoppingCart ShoppingCart, ListView listView, Label labelSum)
        {
            listViewNewShoppingCart.Items.Clear();
            foreach (var element in ShoppingCart.Items)
            {
                ListViewItem listViewItem = new ListViewItem(element.Key.Name);
                listViewItem.SubItems.Add(element.Key.Price);
                listViewItem.SubItems.Add(element.Value.ToString());
                listView.Items.Add(listViewItem);
            }
            ShoppingCart.CalculateSum();
            labelSum.Text = ShoppingCart.Sum.ToString();
            ShowMessageAboutShoppingCart(ShoppingCart);
        }

        private void ShowMessageAboutShoppingCart(ShoppingCart newShoppingCart)
        {
            List<Item> items = newShoppingCart.Items.Keys.Where(item => item.Type != "1").ToList();
            if(items.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("In this shopping cart There is sum of internal items of the store.");
                sb.AppendLine("Because of this the comparison may be incorrect.");
                sb.AppendLine("The internal items:");
                foreach (var item in items)
                {
                    sb.AppendLine(item.Name);
                }
                MessageBox.Show(sb.ToString());
            }
        }
    }
}
