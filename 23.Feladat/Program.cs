using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Írj programot, amely beolvas egy egész számot, majd elosztja 2 - vel annyiszor,
            ahányszor lehet és közben felírja a számot a kettes számok szorzataként
            megszorozva egy olyan számmal, amely már nem osztható 2 - vel.Például:*/
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            int szam1 = 0;
            while (szam % 2 == 0)
            {
                szam /= 2;
                szam1++;
            }
            Console.Write($"2^{szam1}*{szam}");
            Console.ReadKey();
        }
    }
}
