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
    public partial class Form1 : Form
    {
        //slide - header list<string>
        //presentation - List<slide>
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PriceCompareParser comparer = new PriceCompareParser();
            List<ChainStore> Chaines =  comparer.Parse();
        }
    }
}
