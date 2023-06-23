using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_losowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 10; // liczba liczb parzystych do wygenerowania

            Console.WriteLine("Wersja 1 - sprawdzanie poprawności losowania po losowaniu:");
            int licznik1 = 0; // licznik losowań #1
            for (int i = 0; i < n; i++)
            {
                int liczba;
                do
                {
                    liczba = rand.Next(-8, 9);
                    licznik1++;
                } while (liczba % 2 != 0);

                Console.Write(liczba);

                if (i < n - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("Ilość losowań: " + licznik1);

            Console.WriteLine();

            Console.WriteLine("Wersja 2 - losowanie liczby parzystej od razu:");
            int licznik2 = 0; // licznik losowań #2
            for (int i = 0; i < n; i++)
            {
                int liczba = rand.Next(-4, 5) * 2;
                licznik2++;

                Console.Write(liczba);

                if (i < n - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("Ilość losowań: " + licznik2);
        }
    }
}
