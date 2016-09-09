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
    public partial class LoginRegisterForm : Form
    {
        PriceCompareManager manager;
        User user;
        PriceCompareForm priceCompareForm;

        public LoginRegisterForm()
        {
            InitializeComponent();
            manager = new PriceCompareManager();
            //PriceCompareParser comparer = new PriceCompareParser();
            //List<ChainStore> Chaines = comparer.Parse();
        }

        private void buttonNotAnunymos_Click(object sender, EventArgs e)
        {
            if(radioButtonLogin.Checked == true)
            {
                user = Login(textBoxName.Text, textBoxPassword.Text);
                if(user != null)
                {
                    priceCompareForm = new PriceCompareForm(user);
                    priceCompareForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nPlease enter valid name and password!!");
                }
            }
            else if (radioButtonResgister.Checked == true)
            {
                user = Register(textBoxName.Text, textBoxPassword.Text);
                if (user != null)
                {
                    priceCompareForm = new PriceCompareForm(user);
                    priceCompareForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!\nPlease enter name and password again!\nMaybe this name is already in the system.");
                }
            }
            else
            {
                MessageBox.Show("Please select one of the radio buttons!");
            }
        }

        private User Register(string name, string password)
        {
            return manager.AddUser(name, password);
        }

        private User Login(string name, string password)
        {
            return manager.Login(name, password);
        }

        private void buttonAnonymous_Click(object sender, EventArgs e)
        {
            //priceCompareForm = new PriceCompareForm(null);
            //priceCompareForm.ShowDialog();
            PriceCompareParser parser = new PriceCompareParser();
            parser.Parse();
            PriceCompareDataAccess dataAc = new PriceCompareDataAccess();
            var items = dataAc.GetAllItems().ToList();
            var stores = dataAc.GetAllStores().ToList();
            var users = dataAc.GetAllUsers().ToList();
            this.Close();
            //PriceCompareParser parser = new PriceCompareParser();
            ////parser.Parse();
            //PriceCompareDataAccess dataAc = new PriceCompareDataAccess();
            //dataAc.DeleteAll();
            
        }

    }
}
