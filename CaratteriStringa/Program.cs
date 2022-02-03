using System;
using System.Linq;

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

            //LINQ: esempi
            var prova = from c in stringa where c == 'i' select c;  //rende un IEnumerable di tutte le "i" che compaiono
            var prova2 = stringa.Where(c => c == 'i').Count();      //conta le volte in cui compare "i"
            var prova3 = stringa.Where(c => c == 'i').ToArray();    //rende tutte le "i" in un Array

            Console.WriteLine();
        }
    }
}
