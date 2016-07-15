using System;
using System.Drawing;
using System.Windows.Forms;
using Backgammon.Properties;
using System.Linq;
using LogicBackgammon;
using System.Drawing.Drawing2D;

namespace Backgammon
{
    public partial class BackgammonForm : Form
    {
        BackgammonManager manager;
        bool isPanelClicked;
        bool isClickedFirstPictureBox;
        bool isClickedSecondPictureBox;
        Panel[] panels;
        Panel panelBar;
        public BackgammonForm(BackgammonManager.GameMode gameMode,string yourName, string friendName)
        {
            manager = new BackgammonManager(gameMode, yourName, friendName);
            InitializeComponent();
            isPanelClicked = false;
            isClickedFirstPictureBox = false;
            isClickedSecondPictureBox = false;
            panels = Controls.OfType<Panel>().Where(panelName => panelName.Name.StartsWith("panel")).
            OrderBy(panelPos => int.Parse(panelPos.Name.Replace("panel", ""))).ToArray();
            panelBar = barPanel;
            InitPanels();
            PaintBoard();
        }

        private void InitPanels()
        {
            for (int i = 0; i < 24; i++)
            {
                panels[i].Parent = pictureBox1;
            }
            panelBar.Parent = pictureBox1;
        }

        private void PaintBoard()
        {
            for(int i = 0; i < 24; i++)
            {
                
                if (manager.GameBoard.Board[i].CheckersColor != Color.Transparent)
                {
                    Bitmap bitmap = new Bitmap(panels[i].Size.Width, panels[i].Size.Height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    Pen pen = new Pen(Color.Black);
                    SolidBrush brush;
                    if (manager.GameBoard.Board[i].CheckersColor == Color.Red)
                    {
                        brush = new SolidBrush(Color.Red);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.Blue);
                    }
                    int yPos = 0;
                    for (int j = 0; j < manager.GameBoard.Board[i].Checkers; j++)
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawEllipse(pen, 0, yPos, 20, 20);
                        graphics.FillEllipse(brush, 0, yPos, 20, 20);
                        yPos += 25;
                    }
                    panels[i].BackgroundImage = bitmap;
                }
                Invalidate();
            }
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

        private void panel_Click(object sender, MouseEventArgs e)
        {
            //Panel currentPanel = (Panel)sender;
            //int panelIndex = int.Parse(currentPanel.Name.Replace("panel", ""));

        }

        private void pictureBoxFirstCube_Click(object sender, EventArgs e)
        {
            isClickedFirstPictureBox = true;
        }

        private void pictureBoxSecondCube_Click(object sender, EventArgs e)
        {
            isClickedSecondPictureBox = true;
        }
    }
}
