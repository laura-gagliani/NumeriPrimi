using System;
using System.Linq;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Gen = new Random();
            int rndNum = Gen.Next(1000);

            if (rndNum % 2 == 0)
            {
                Console.WriteLine($"Il numero {rndNum} è pari");
            }
            else
                Console.WriteLine($"Il numero {rndNum} è dispari");


            Random rnd = new Random();
            int[] a = new int[10];

            Console.WriteLine("Il vettore è:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 101);
                Console.Write(a[i] + "\t");

            }

            var evens = a.Where(i => i % 2 == 0).ToArray();
            var odds = a.Where(i => i % 2 != 0).ToArray();

            Console.WriteLine("\nElementi pari:");
            foreach (var item in evens)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\nElementi dispari:");
            foreach (var item in odds)
            {
                Console.Write(item + "\t");
            }

        }

        
    }
}
