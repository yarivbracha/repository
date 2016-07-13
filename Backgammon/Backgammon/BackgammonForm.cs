using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public partial class BackgammonForm : Form
    {
        public BackgammonForm(LogicBackgammon.BackgammonManager.GameMode gameMode,string yourName, string friendName)
        {
            InitializeComponent();
            //listBox1.BackColor = Color.Black;
        }

        private void BackgammonForm_Load(object sender, EventArgs e)
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            //this.Update();
        }

      
    }
}
