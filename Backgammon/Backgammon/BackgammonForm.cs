using System;
using System.Drawing;
using System.Windows.Forms;
using Backgammon.Properties;
using System.Linq;
using LogicBackgammon;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Backgammon
{
    public partial class BackgammonForm : Form
    {
        BackgammonManager manager;
        BackgammonBoard board;
        Panel[] panels;
        PictureBox[] cubes;
        Panel panelBar;
        int panelIndex;
        bool isPanelClicked;
        bool isWinner;

        public BackgammonForm(BackgammonManager.GameMode gameMode,string yourName, string friendName)
        {
            manager = new BackgammonManager(gameMode, yourName, friendName);
            board = BackgammonBoard.Instance;
            InitializeComponent();
            panels = Controls.OfType<Panel>().Where(panelName => panelName.Name.StartsWith("panel")).
            OrderBy(panelPos => int.Parse(panelPos.Name.Replace("panel", ""))).ToArray();
            InitCubesPictures();
            panelIndex = -2;
            isPanelClicked = false;
            panelBar = barPanel;
            InitPanels();
            PaintBoard();
            manager.StartGame();
            setPanelsAndCubesEnabled(false);
            isWinner = false;
            ComputerPlay();
            buttonPlay.Enabled = true;
        }

        private void ComputerPlay()
        {
            while ((typeof(ComputerPlayer) == manager.CurrentPlayer.GetType()) && (!isWinner))
            {
                buttonPlay.Enabled = false;
                manager.GameCubes.RollCube();
                SetCubes();
                if (manager.GameCubes.IsDoubled)
                {
                    pictureBoxCube3.Enabled = false;
                    pictureBoxCube4.Enabled = false;
                }
                pictureBoxCube1.Enabled = false;
                pictureBoxCube2.Enabled = false;

               if(!manager.PlayComputerMove())
                {
                    MessageBox.Show($"There is no legal moves for {manager.CurrentPlayer.Name}");
                }
                PaintBoard();
                Thread.Sleep(2000);
                isWinner = manager.IsWinner();
                if(isWinner)
                {
                    MessageBox.Show($"The game is over!\n The winner is {manager.CurrentPlayer.Name}!");
                }
                SwitchTurn();
            }
        }

        private void InitCubesPictures()
        {
            cubes = new PictureBox[4];
            cubes[0] = pictureBoxCube1;
            cubes[1] = pictureBoxCube2;
            cubes[2] = pictureBoxCube3;
            cubes[3] = pictureBoxCube4;
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
                
                if (board.Board[i].CheckersColor != Color.Transparent)
                {
                    Bitmap bitmap = new Bitmap(panels[i].Size.Width, panels[i].Size.Height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    Pen pen = new Pen(Color.Black);
                    SolidBrush brush;
                    if (board.Board[i].CheckersColor == Color.Red)
                    {
                        brush = new SolidBrush(Color.Red);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.Blue);
                    }
                    int yPos = 0;
                    for (int j = 0; j < board.Board[i].Checkers; j++)
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawEllipse(pen, 5, yPos, 20, 20);
                        graphics.FillEllipse(brush, 5, yPos, 20, 20);
                        yPos += 25;
                    }
                    panels[i].BackgroundImage = bitmap;
                }
                Invalidate();
            }
        }

        private void  SetCubes()
        {
            if (manager.GameCubes.IsDoubled == true)
            {
                SetCubePictureBox(pictureBoxCube3, manager.GameCubes.FirstCube);
                SetCubePictureBox(pictureBoxCube4, manager.GameCubes.FirstCube);
            }
            else
            {
                setEnabledAndVisibilityPictureBox(pictureBoxCube3, false);
                setEnabledAndVisibilityPictureBox(pictureBoxCube4, false);
            }
            SetCubePictureBox(pictureBoxCube1, manager.GameCubes.FirstCube);
            SetCubePictureBox(pictureBoxCube2, manager.GameCubes.SecondCube);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            manager.GameCubes.RollCube();
            SetCubes();
            buttonPlay.Enabled = false;
            setPanelsAndCubesEnabled(true);
            if (!manager.CurrentPlayer.IsValidMoves(manager.GameCubes.FirstCube))
            {
                setEnabledAndVisibilityPictureBox(pictureBoxCube1, false);
            }
            if(manager.GameCubes.IsDoubled && pictureBoxCube1.Visible == false)
            {
                MessageBox.Show("There is no available moves for {0}", manager.CurrentPlayer.Name);
                SwitchTurn();
                return;
            }
            if (!manager.CurrentPlayer.IsValidMoves(manager.GameCubes.SecondCube))
            {
                setEnabledAndVisibilityPictureBox(pictureBoxCube2, false);
            }
            if((pictureBoxCube2.Visible == false) && (pictureBoxCube1.Visible == false))
            {
                MessageBox.Show($"There is no available moves for {manager.CurrentPlayer.Name} The cubes was {manager.GameCubes.FirstCube} {manager.GameCubes.SecondCube}");
                SwitchTurn();
            }
        }

        private void setEnabledAndVisibilityPictureBox(PictureBox cube, bool isEnableAndVisibilty)
        {
            cube.Enabled = isEnableAndVisibilty;
            cube.Visible = isEnableAndVisibilty;
        }

        private void SwitchTurn()
        {
            setPanelsAndCubesEnabled(false);
            manager.SwitchPlayer();
            buttonPlay.Enabled = true;
            panelIndex = -2;
            setEnabledAndVisibilityPictureBox(pictureBoxCube3, false);
            setEnabledAndVisibilityPictureBox(pictureBoxCube4, false);
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
            setEnabledAndVisibilityPictureBox(pictureBoxCube, true);
        }

        private void panel_Click(object sender, MouseEventArgs e)
        {
            foreach(Panel panel in panels)
            {
                panel.BackColor = Color.Transparent;
            }
            Panel currentPanel = (Panel)sender;
            string panelIndexOrBar = currentPanel.Name.Replace("panel", "");
            if (panelIndexOrBar.Equals("bar"))
            {
                if (manager.CurrentPlayer.Status == Player.GameStatus.Out)
                {
                    isPanelClicked = true;
                    panelBar.BackColor = Color.White;
                    panelIndex = -1;
                }
            }
            else
            {
                panelIndex = int.Parse(panelIndexOrBar);
                if (board.Board[panelIndex].CheckersColor == manager.CurrentPlayer.PlayerColor)
                {
                    isPanelClicked = true;
                    panels[panelIndex].BackColor = Color.White;
                }
            }
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            if (isPanelClicked)
            {
                PictureBox cube = (PictureBox)sender;
                int cubeSum = GetCubeSum(cube);
                if (manager.CurrentPlayer.DoMove(panelIndex, cubeSum))
                {
                    isPanelClicked = false;
                    setEnabledAndVisibilityPictureBox(cube, false);
                    if (IsNoMoreMoves())
                    {
                        if (manager.IsWinner())
                        {
                            MessageBox.Show($"The game is over!\nThe winner is {manager.CurrentPlayer.Name}!");
                        }
                        else
                        {
                            SwitchTurn();
                            ComputerPlay();
                        } 
                    }
                    else
                    {
                        if (manager.IsWinner())
                        {
                            MessageBox.Show($"The game is over!\nThe winner is {manager.CurrentPlayer.Name}!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"The move from {panelIndex} with {cubeSum} steps is illegal, please try again");
                }
            }
            else
            {
                MessageBox.Show("Please choose legal checker and later choose cube");
            }
        }

        private int GetCubeSum(PictureBox cube)
        {
            int sum;
            int cubeNumber = int.Parse(cube.Name.Replace("pictureBoxCube", ""));
            if(cubeNumber == 1)
            {
                sum = manager.GameCubes.FirstCube;
            }
            else
            {
                sum = manager.GameCubes.SecondCube;
            }
            return sum;
        }

        private bool IsNoMoreMoves()
        {
            bool isMoreTurns = true;
            if (pictureBoxCube1.Visible == true)
            {
                if (!manager.CurrentPlayer.IsValidMoves(manager.GameCubes.FirstCube))
                {
                    setEnabledAndVisibilityPictureBox(pictureBoxCube1, false);
                }
            }
            if (pictureBoxCube2.Visible == true)
            {
                if (!manager.CurrentPlayer.IsValidMoves(manager.GameCubes.SecondCube))
                {
                    setEnabledAndVisibilityPictureBox(pictureBoxCube2, false);
                }
            }
            if ((pictureBoxCube1.Visible == false) && (pictureBoxCube2.Visible == false)
                && (pictureBoxCube3.Visible == false) && (pictureBoxCube4.Visible == false))
            {
                isMoreTurns = false;
            }
            return isMoreTurns;
        }

        private void setPanelsAndCubesEnabled(bool isEnable)
        {
            for(int i = 0; i < 24; i++)
            {
                panels[i].Enabled = isEnable;
            }
            panelBar.Enabled = isEnable;
            pictureBoxCube1.Enabled = isEnable;
            pictureBoxCube2.Enabled = isEnable;
        }
    }
}
