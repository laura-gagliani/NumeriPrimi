using System;

namespace OrderArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //ordinamento crescente
            int[] array = new int[] { 2, 34, 1, 234, 5, 4 };

            int min;
            int index = 0;
            int x;

            for (int j = 0; j < array.Length; j++)
            {
                min = array[j];

                for (int i = j; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        index = i;
                    }
                }
                //esco dal ciclo che ho trovato il minimo E la sua posizione
                //scambio 
                x = array[j];
                array[j] = min;
                array[index] = x;

                
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //ordinamento decrescente

            int[] a = new int[] { 3, 89, 3, 4, 0, 12, 64 };

            int max;
            int pos = 0;
            int box;

            for (int i = 0; i < a.Length; i++)
            {
                max = a[i];

                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] > max)
                    {
                        max = a[j];
                        pos = j;
                    }
                }
                box = a[i];
                a[i] = max;
                a[pos] = box;

            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }



            //riprova decrescente

            Random rnd = new Random();
            int[] b = new int[10];

            Console.WriteLine("\nIl vettore è:");
            for (int i = 0; i < b.Length; i++)
            {
                a[i] = rnd.Next(1, 101);
                Console.Write(b[i] + "\t");

            }

            int position = 0;
            int spare;
            int maximum;

            for (int i = 0; i < b.Length; i++)
            {
                maximum = b[i];

                for (int j = i; j < b.Length; j++)
                {
                    if (b[j] > maximum)
                    {
                        maximum = b[j];
                        position = j;
                    }
                }
                //uscita da qua ho sicuramente il vero massimo
                spare = b[i];
                b[i] = maximum;
                b[position] = spare;

            }

        }
    }
}
