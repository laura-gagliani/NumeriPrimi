using System;
using System.Collections.Generic;

namespace numeriprimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // dato un numero vedere se è primo

            Random rndGenerator = new Random();
            int num = rndGenerator.Next(200);

            bool isPrime = CheckPrimeNum(num);
            Console.WriteLine($"{num} è primo? {isPrime}");

            //dato un intervallo di numeri trovare i primi

            int num2 = rndGenerator.Next(200);

            int[] series = new int[num2]; // array vuoto
            for (int i = 0; i < series.Length; i++) // popolazione array (da 0 a num2-1)
            {
                series[i] = i;
            }

            List<int> primes = new List<int>();
            primes = CheckPrimeSeries(series);
            foreach (var item in primes)
            {
                Console.Write($"{item}\t");
            }


        }

        private static List<int> CheckPrimeSeries(int[] series)
        {
            List<int> primes = new List<int>();

            for (int i = 0; i < series.Length; i++)
            {
                bool isPrime = CheckPrimeNum(series[i]);
                if (isPrime)
                {
                    primes.Add(series[i]);
                }
            }

            return primes;
        }

        private static bool CheckPrimeNum(int num)
        {
            bool isPrime = true;

            if (num == 0 || num == 1)
            {
                return isPrime = false;
            }

            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return isPrime = false;
                    }

                }
            }
            return isPrime;
        }
    }
}
