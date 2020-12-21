using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{

    struct Osoba {

        public string imie;
        public string nazwisko;
        public string adres;
        public string telefon;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba os;

            Console.WriteLine("Podaj imie: ");
            os.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            os.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj adres: ");
            os.adres = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu");
            os.telefon = Console.ReadLine();

            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("* "+ os.imie + " " + os.nazwisko + " *");
            Console.WriteLine("* " + os.adres + " *");
            Console.WriteLine("* " + os.telefon + " *");
            Console.WriteLine();
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }


            // naprawa wizytówki
            // etap 1. znalezienie najdłuższego napisu - n
            // etap 2. obliczenie n+2+2 - ilość gwiazdek w wierszu otwierającym i zamykającym
            // etap 3. obliczenie ilość spacji w pozostałych wierszach - (n+4 - 2) / 2
            // etap 4. zbadanie kwestii parzystości długości napisów

            Console.ReadKey();



        }
    }
}
