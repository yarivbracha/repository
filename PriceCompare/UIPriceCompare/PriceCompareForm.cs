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
        public PriceCompareForm(User user)
        {
            InitializeComponent();
            this.user = user;
            manager = new PriceCompareManager();
            AddStoresToListView();
           // ListViewItem l = new ListViewItem("חצי חינם");
           //// l.SubItems.Add("dd");
           // l.SubItems.Add("חולון");
           // listViewStores.Items.Add(l);
        }

        private void listViewStores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStoresToListView()
        {
            foreach (Store store in manager.GetAllStores())
            {
                ListViewItem storeItem = new ListViewItem(store.ChainStoreName);
                storeItem.SubItems.Add(store.Name);
                listViewStores.Items.Add(storeItem);
            }
        }
    }
}
