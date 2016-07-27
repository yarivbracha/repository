using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesCalculator
{
    public partial class FormPrimesCalculatur : Form
    {
        public FormPrimesCalculatur()
        {
            InitializeComponent();
        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            string firstNumberString = textBoxFirstNumber.Text;
            string secondNumberString = textBoxSecondNumber.Text;
            while (!IsValidNumbers(firstNumberString,secondNumberString))
            {
                MessageBox.Show("Please enter valid numbers in the text boxes!");
            }
            List<int> numbers = await Task.Run(()=> CalculatePrimes(firstNumberString, secondNumberString));
            
        }

        public List<int> CalculatePrimes(string firstNumberString, string secondNumberString)
        {
            int first = int.Parse(firstNumberString);
            int second = int.Parse(secondNumberString);
            List<int> listNumbers = new List<int>();
            int max = Math.Max(first, second);
            int min = Math.Min(first, second);
            for (int i = min; i < max; i++)
            {
                 if (i > 2)
                 {
                     double limit = Math.Sqrt(i);
                     for (int j = 2; j < limit; j++)
                     {
                         if (i % j == 0)
                         {
                            listNumbers.Add(i);
                            break;
                         }
                    }
                }
            }
            return listNumbers;
        }

        private bool IsValidNumbers(string firstNumber, string secondNumber)
        {
            bool isValid = true;
            int first, second;
            if(String.IsNullOrEmpty(firstNumber) || String.IsNullOrEmpty(secondNumber))
            {
                isValid = false;
            }
            else
            {
                if((!int.TryParse(firstNumber,out first) || (!int.TryParse(secondNumber,out second))))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
