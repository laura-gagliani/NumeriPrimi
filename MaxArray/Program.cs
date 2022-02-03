using System;
using System.Linq;

namespace MaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {3, 54, 0, 23, 5, 13, 3 };

            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine(max);

            Random rnd = new Random();
            int[] b = new int[10];

            Console.WriteLine("Il vettore è:");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(1, 101);
                Console.Write(b[i] + "\t");

            }

            int maxB = b.Max();
            Console.WriteLine("\n il max è: "+ maxB);
        }
    }
}
