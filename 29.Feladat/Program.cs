using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Írj programot, ami beolvas egy számot, majd kiírja a szám prímtényezős felbontását!*/
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int eredetiSzam = szam;
            List<int> primtenyezok = new List<int>();
            for (int i = 2; i <= szam; i++)
            {
                while (szam % i == 0)
                {
                    primtenyezok.Add(i);
                    szam /= i;
                }
            }
            Console.WriteLine($"{eredetiSzam} = {string.Join(" * ", primtenyezok)}");
            Console.ReadKey();

        }
    }
}
