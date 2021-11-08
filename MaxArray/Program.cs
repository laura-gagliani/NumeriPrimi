using System;

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
        }
    }
}
