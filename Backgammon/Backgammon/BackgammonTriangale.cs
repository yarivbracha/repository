using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public partial class BackgammonTriangale : UserControl
    {
        private int amount;
        private Color color;
        private PictureBox[] picturesArray = new PictureBox[5];

        public BackgammonTriangale(Bitmap BackgroundPicture, int amount, Color color)
        {
            InitializeComponent();
            this.color = color;
            this.amount = amount;
            labelTriangleAmount.Text = amount.ToString();
            this.BackgroundImage = BackgroundPicture;
            picturesArray[0] = pictureBox1;
            picturesArray[1] = pictureBox2;
            picturesArray[2] = pictureBox3;
            picturesArray[3] = pictureBox4;
            picturesArray[4] = pictureBox5;

        }

        

        private void DrawPictures()
        {
            for(int i =0; i < amount; i++)
            {
                picturesArray[i].BackColor = color;
            }
        }

        private void Add()
        {
            amount++;
            labelTriangleAmount.Text = amount.ToString();
        }

        public void Dec()
        {
            amount--;
            labelTriangleAmount.Text = amount.ToString();
            if(amount == 0)
            {
                color = Color.Transparent;
            }
        }
    }
}
