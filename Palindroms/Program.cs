using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = true;
            string palindromo = "onorarono";

            //for (int i = 0; i < palindromo.Length; i++)
            //{
            //    if (palindromo[i] != palindromo[palindromo.Length - 1 - i])
            //    {
            //        isEqual = false;
            //    }
            //}

            for (int i = 0; i <= palindromo.Length/2; i++)
            {
                if (palindromo[i] != palindromo[palindromo.Length - 1 - i])
                {
                    isEqual = false;
                }
            }

            Console.WriteLine(isEqual);
        }
    }
}
