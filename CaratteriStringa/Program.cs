using System;

namespace CaratteriStringa
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string stringa = "supercalifragilistichespiralitoso";
            char carattere = 'i';

            foreach (char c in stringa)
            {
                if (c == carattere)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Il carattere {carattere} è stato trovato {count} volte");

            }
            else
                Console.WriteLine($"Il carattere {carattere} non è stato trovato");
        }
    }
}
