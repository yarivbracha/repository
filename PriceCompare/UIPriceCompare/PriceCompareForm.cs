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
    public partial class PriceCompareForm : Form
    {
        private User user;
        private PriceCompareManager manager;
        private List<Store> stores;
        public PriceCompareForm(User user)
        {
            InitializeComponent();
            this.user = user;
            manager = new PriceCompareManager();
            AddStoresToListView();
        }

        private void listViewStores_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
