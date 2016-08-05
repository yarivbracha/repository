using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            Console.WriteLine("Start to calculate");
            primes = CalcPrimes(1, 30000000);
            Console.WriteLine($"{primes.Count()} primes numbers");
        }

        private static List<int> CalcPrimes(int first, int last)
        {
            List<int> listPrimes = new List<int>();
            Random random = new Random();
            Parallel.For(first, last, (number, state) => 
            {
                lock (random)
                {
                    if (random.Next(10000000) == 0)
                    {
                        Console.WriteLine("The operation cancelled");
                        state.Stop();
                        return;
                    }
                }
                double limit = Math.Sqrt(number);
                bool isPrime = true;
                for (int j = 2; j <= limit; j++)
                {
                    if (number % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    lock (listPrimes)
                    {
                        listPrimes.Add(number);
                    }
                }
            });
            return listPrimes;
        }
    }
}
