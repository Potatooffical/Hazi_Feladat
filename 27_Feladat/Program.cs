using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Írj programot, amely beolvas egy egész számot, majd elosztja 2-vel annyiszor,
            ahányszor lehet és közben felírja a számot a kettes számok szorzataként
            megszorozva egy olyan számmal, amely már nem osztható 2-vel.*/
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            int osztodb = 0;
            for (int i = 2; i < szam; i++)
            {
                for (int j = 1; j < szam; j++)
                {
                    if (i % j == 0)
                    {
                        osztodb++;
                    }
                }
                if (osztodb == 2)
                {
                    Console.Write($"{i}");
                }
                szam = 0;
            }
            
            
            Console.ReadKey();
        }
    }
}
