using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Degree : {i}");
                primes = CalcPrimes(1, 10000000, i);
                Console.WriteLine($"Total primes numbers: {primes.Count}");
            }
        }

        private static List<int> CalcPrimes(int first, int last, int degree)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = degree };
            List<int> listPrimes = new List<int>();
            Parallel.For(first, last, options, number =>
            {
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
