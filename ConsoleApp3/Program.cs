using System;

namespace Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "0. Kina", "1. Indien", "2. USA", "3. Indonesien", "4. Pakistan" };
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }
            string[] sträng = Console.ReadLine().Split(" ");
            Int64[] nummer = Array.ConvertAll(sträng, s => Int64.Parse(s)); // Använder Int64 så att man kan multiplicera större tal

            for (int x = 0; x < nummer.Length; x++)
            {
                Console.WriteLine(countries[nummer[x]]);
            }


        }
    }
}