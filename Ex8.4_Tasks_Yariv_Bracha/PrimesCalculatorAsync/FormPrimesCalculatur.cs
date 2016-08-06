using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesCalculatorAsync
{
    public partial class FormPrimesCalculatur : Form
    {
        private int countPrimes;
        private CancellationTokenSource cancellationToken;

        public FormPrimesCalculatur()
        {
            InitializeComponent();
            cancellationToken = new CancellationTokenSource();
        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            object objToLock = new object();
            string firstNumberString = textBoxFirstNumber.Text;
            string secondNumberString = textBoxSecondNumber.Text;
            string fileOutputName = textBoxOutputFile.Text;
            if (String.IsNullOrEmpty(fileOutputName))
            {
                MessageBox.Show("Please enter output file name!");
            }
            else
            {
                bool isValidNumbers = IsValidNumbers(firstNumberString, secondNumberString);
                if (!isValidNumbers)
                {
                    MessageBox.Show("Please enter valid numbers in the text boxes!");
                }
                else
                {
                    cancellationToken.Dispose();
                    cancellationToken = new CancellationTokenSource();
                    countPrimes = 0;
                    labelResult.Visible = false;
                    await Task.Run(() => CountPrimesAsync(firstNumberString, secondNumberString), cancellationToken.Token);
                    try
                    {
                        writer = new StreamWriter(fileOutputName + ".txt", true);
                    }
                    catch(IOException)
                    { }
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        labelResult.Text = countPrimes.ToString();
                        writer.WriteLine($"Primes numbers count: {countPrimes.ToString()}");
                        writer.Flush();
                    }
                    else
                    {
                        labelResult.Text = "Operation cancelled!!";
                    }
                    
                    labelResult.Visible = true;
                }
                writer.Close();
            }
        }


        public async void CountPrimesAsync(string firstNumberString, string secondNumberString)
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
                        if (cancellationToken.IsCancellationRequested)
                        {
                            MessageBox.Show("The operation cancelled!");
                            return;
                        }
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        countPrimes++;
                    }
                }
            }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }
    }
}
