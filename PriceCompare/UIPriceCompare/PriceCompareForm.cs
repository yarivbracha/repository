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
    public partial class PriceCompareForm : Form
    {
        private User user;
        public PriceCompareForm(User user)
        {
            InitializeComponent();
            this.user = user;
            
        }
    }
}
