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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void radioButtonAgainstFriend_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAgainstFriend.Checked == true)
            {
                textBoxPlayerName.Visible = true;
                labelFriendName.Visible = true;
                textBoxFriendName.Visible = true;
                labelFriendName.Visible = true;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if((radioButtonAgainstComputer.Checked == true) || (radioButtonAgainstFriend.Checked == true) || (radioButton2Computers.Checked == true))
            {
                if(radioButton2Computers.Checked == true)
                {
                    LogicBackgammon.BackgammonManager.GameMode gameMode = LogicBackgammon.BackgammonManager.GameMode.TwoComputers;
                    BackgammonForm gameForm = new BackgammonForm(gameMode, null, null);
                    //this.Hide();
                    gameForm.ShowDialog();
                    this.Close();
                }
                else if(!String.IsNullOrEmpty(textBoxPlayerName.Text))
                {
                    if(radioButtonAgainstFriend.Checked != true)
                    {
                        LogicBackgammon.BackgammonManager.GameMode gameMode = LogicBackgammon.BackgammonManager.GameMode.Computer;
                        BackgammonForm gameForm = new BackgammonForm(gameMode, textBoxPlayerName.Text, null);
                        //this.Hide();
                        gameForm.ShowDialog();
                        this.Close();
                    }
                    else if(String.IsNullOrEmpty(textBoxFriendName.Text))
                    {
                        MessageBox.Show("Please enter friend name!");
                    }
                    else
                    {
                        LogicBackgammon.BackgammonManager.GameMode gameMode = LogicBackgammon.BackgammonManager.GameMode.Friend;
                        BackgammonForm gameForm = new BackgammonForm(gameMode, textBoxPlayerName.Text, textBoxFriendName.Text);
                        //this.Hide();
                        gameForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Your name!");
                }
            }
            else
            {
                MessageBox.Show("Please choose game mode!");
            }
        }

        private void radioButton2Computers_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2Computers.Checked == true)
            {
                textBoxFriendName.Visible = false;
                textBoxPlayerName.Visible = false;
                labelFriendName.Visible = false;
                labelYourName.Visible = false;
            }
        }

        private void radioButtonAgainstComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAgainstComputer.Checked == true)
            {
                textBoxFriendName.Visible = false;
                textBoxPlayerName.Visible = true;
                labelFriendName.Visible = false;
                labelYourName.Visible = true;
            }
        }
    }
}
