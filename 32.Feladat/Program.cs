using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, ami beolvas egy számot, és kiírja az ilyen alapú szorzótáblát! 
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{szam} szorzótáblája:\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{szam} * {i} = {szam * i}");
            }
            Console.ReadKey();
        }
    }
}
