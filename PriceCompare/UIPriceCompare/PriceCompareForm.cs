using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPriceCompare;
using LogicPriceCompare;

namespace UIPriceCompare
{
    public partial class PriceCompareForm : Form
    {
        private User user;
        private PriceCompareManager manager;
        private List<Store> stores;
        private long selectedStoreId;
        private List<Item> items;
        private ShoppingCart shoppingCart;

        public PriceCompareForm(User user)
        {
            InitializeComponent();
            this.user = user;
            manager = new PriceCompareManager();
            AddStoresToListView();
            if(user == null)
            {
                buttonSaveShopingCart.Visible = false;
                buttonShowLast.Visible = false;
            }
        }

        private void listViewStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStores.SelectedItems.Count == 0)
            {
                return;
            }
            dataGridViewItems.Rows.Clear();
            ListViewItem item = listViewStores.SelectedItems[0];
            selectedStoreId = long.Parse(item.Text);
            items = manager.GetItemsByStoreId(selectedStoreId);
            AddItemsToDataGridView();
            UpdateThreeExpensiveItems();
            UpdateThreeCheapItems();
        }

        private void AddStoresToListView()
        {
            stores = manager.GetAllStores();
            foreach (Store store in stores)
            {
                ListViewItem storeItem = new ListViewItem(store.Id.ToString());
                storeItem.SubItems.Add(store.Name);
                storeItem.SubItems.Add(store.ChainStoreName);
                listViewStores.Items.Add(storeItem);
            }
        }

        private void AddItemsToDataGridView()
        {
            foreach (Item item in items)
            {
                if(item.UnitOfMeasure.ToString().Contains("00000000000000000"))
                {
                    item.UnitOfMeasure =  item.UnitOfMeasure.Replace("00000000000000000", "");
                }
                dataGridViewItems.Rows.Add(new object[] { null, null, item.Id.ToString(), item.Name , item.Price, item.Quantity, item.UnitOfMeasure, item.Code, item.Type});
            }
        }

        

        private void UpdateThreeCheapItems()
        {
            listBoxStoreCheapItems.Items.Clear();
            var mostExpensive = items.OrderBy(item => double.Parse(item.Price));
            listBoxStoreCheapItems.Items.Add(mostExpensive.First());
            listBoxStoreCheapItems.Items.Add(mostExpensive.Skip(1).First());
            listBoxStoreCheapItems.Items.Add(mostExpensive.Skip(2).First());

        }

        private void UpdateThreeExpensiveItems()
        {
            listBoxStoreExpensiveItems.Items.Clear();
            var cheapest = items.OrderByDescending(item => double.Parse(item.Price));
            listBoxStoreExpensiveItems.Items.Add(cheapest.First());
            listBoxStoreExpensiveItems.Items.Add(cheapest.Skip(1).First());
            listBoxStoreExpensiveItems.Items.Add(cheapest.Skip(2).First());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int amount;
            double price;
            shoppingCart = new ShoppingCart(selectedStoreId);
            for(int i = 0; i < dataGridViewItems.Rows.Count; i++)
            {
                var isChecked = dataGridViewItems.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(isChecked.Value) == true)
                {
                    if(dataGridViewItems.Rows[i].Cells[1].Value != null)
                    {
                        if(int.TryParse(dataGridViewItems.Rows[i].Cells[1].Value.ToString(), out amount))
                        {
                            Item item = new Item();
                            item.Id = long.Parse(dataGridViewItems.Rows[i].Cells[2].Value.ToString());
                            item.Name = dataGridViewItems.Rows[i].Cells[3].Value.ToString();
                            if (double.TryParse(dataGridViewItems.Rows[i].Cells[4].Value.ToString(), out price))
                            {
                                item.Price = dataGridViewItems.Rows[i].Cells[4].Value.ToString();
                            }
                            item.StoreId = selectedStoreId;
                            item.Quantity = dataGridViewItems.Rows[i].Cells[5].Value.ToString();
                            item.UnitOfMeasure = dataGridViewItems.Rows[i].Cells[6].Value.ToString();
                            item.Code = dataGridViewItems.Rows[i].Cells[7].Value.ToString();
                            item.Type = dataGridViewItems.Rows[i].Cells[8].Value.ToString();
                            shoppingCart.AddItem(item, amount);
                        }
                    }
                }
            }
            listBoxShopingCart.Items.Clear();
            PopulateShoppingCart();
        }

        private void PopulateShoppingCart()
        {
            foreach (var item in shoppingCart.Items)
            {
                listBoxShopingCart.Items.Add(item);
            }
            shoppingCart.CalculateSum();
            labelShopingCartPrice.Text = shoppingCart.Sum.ToString();
        }

        private void listBoxStoreCheapItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = listBoxStoreCheapItems.SelectedItem as Item;
            ShowItemDetails(item);
        }

        private void ShowItemDetails(Item item)
        {
            labelNameItem.Text = item.Name;
            labelPriceItem.Text = item.Price;
            labelQuantityItem.Text = item.Quantity;
            labelUnitOfMeasureItem.Text = item.UnitOfMeasure;
        }

        private void listBoxStoreExpensiveItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = listBoxStoreExpensiveItems.SelectedItem as Item;
            ShowItemDetails(item);
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Items.Count > 0)
            {
                ComparerForm comparerForm = new ComparerForm(shoppingCart, stores);
                comparerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select items and add it to the shopping cart!");
            }
        }

        private void buttonSaveShopingCart_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Items.Count > 0)
            {
                manager.SaveShoppingCartToTheUser(user, shoppingCart);
            }
            else
            {
                MessageBox.Show("Please add items to the shopping cart!");
            }
        }

        private void buttonShowLast_Click(object sender, EventArgs e)
        {
            UserShoppingCartForm userShoppingCartForm = new UserShoppingCartForm(user);
            userShoppingCartForm.ShowDialog();
        }
    }
}
