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
            megszorozva egy olyan számmal, amely már nem osztható 2-vel.
             */
            Console.Write("Kérek egy egész számot: ");
            int egeszSzam = int.Parse(Console.ReadLine());
            int oszthato = egeszSzam;
            int kettesHatvany = 0;
            while (oszthato % 2 == 0)
            {
                oszthato /= 2;
                kettesHatvany++;
            }
            Console.WriteLine($"{egeszSzam} = 2^{kettesHatvany} * {oszthato}");
        }
    }
}
