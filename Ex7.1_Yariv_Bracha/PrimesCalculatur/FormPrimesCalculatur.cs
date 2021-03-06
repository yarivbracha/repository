﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesCalculatur
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
            bool isValidNumbers = IsValidNumbers(firstNumberString, secondNumberString);
            if (!isValidNumbers)
            {
                MessageBox.Show("Please enter valid numbers in the text boxes!");
            }
            else
            {
                listBoxNumbers.Items.Clear();
                List<int> numbers = await Task.Run(() => CalculatePrimes(firstNumberString, secondNumberString));
                for (int i = 0; i < numbers.Count; i++)
                {
                    listBoxNumbers.Items.Add(numbers[i]);
                }
            }
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
                    bool isPrime = true;
                    double limit = Math.Sqrt(i);
                    for (int j = 2; j <= limit; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        listNumbers.Add(i);
                    }
                }
            }
            return listNumbers;
        }

        private bool IsValidNumbers(string firstNumber, string secondNumber)
        {
            bool isValid = true;
            int first, second;
            if (String.IsNullOrEmpty(firstNumber) || String.IsNullOrEmpty(secondNumber))
            {
                isValid = false;
            }
            else
            {
                if ((!int.TryParse(firstNumber, out first) || (!int.TryParse(secondNumber, out second))))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
