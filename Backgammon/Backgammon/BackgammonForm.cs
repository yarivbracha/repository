using System;
using System.Drawing;
using System.Windows.Forms;
using Backgammon.Properties;
using LogicBackgammon;

namespace Backgammon
{
    public partial class BackgammonForm : Form
    {
        BackgammonManager manager;
        public BackgammonForm(BackgammonManager.GameMode gameMode,string yourName, string friendName)
        {
            manager = new BackgammonManager(gameMode, yourName, friendName);
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            manager.GameCubes.RollCube();
            SetCubePictureBox(pictureBoxFirstCube, manager.GameCubes.FirstCube);
            SetCubePictureBox(pictureBoxSecondCube, manager.GameCubes.SecondCube);
            buttonPlay.Enabled = false;
        }

        private void SetCubePictureBox(PictureBox pictureBoxCube, int cube)
        {
            Image image = null;
            switch (cube)
            {
                case 1:
                    image = Resources.Cube1;
                    break;
                case 2:
                    image = Resources.Cube2;
                    break;
                case 3:
                    image = Resources.Cube3;
                    break;
                case 4:
                    image = Resources.Cube4;
                    break;
                case 5:
                    image = Resources.Cube5;
                    break;
                case 6:
                    image = Resources.Cube6;
                    break;
            }
            pictureBoxCube.Image = image;
            pictureBoxCube.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
