using System;

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



        }
    }
}
