using System;

namespace VocalsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola = "supercalifragilistichespiralitoso";
            int countVocali = 0;
            int countConsonanti; 

            foreach (char c in parola)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    countVocali++;
                }
            }
            countConsonanti = parola.Length - countVocali;
            Console.WriteLine($"totale: {parola.Length} vocali: {countVocali} consonanti: {countConsonanti}");
        }
    }
}
