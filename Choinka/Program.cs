using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int p = 2 * n - 1;
            int x, k;

            for (int i = 1; i <= n; i++) // wiersze
            {

                x = 2 * i - 1; // ilość gwiazdek
                // spacje
                for (k = 0; k < (p-x)/2; k++)
                {
                    Console.Write(" ");
                }

                // krzyżyki 
                for (k = 0; k < x; k++)
                {
                    Console.Write("*");
                }


                // spacje
                for (k = 0; k < (p - x) / 2; k++)
                {
                    Console.Write(" ");
                }


                // nowa linia
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
