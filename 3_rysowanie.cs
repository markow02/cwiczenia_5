using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_rysowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość trójkąta: ");
            int wysokosc = int.Parse(Console.ReadLine());

            int szerokosc = wysokosc * 2 - 1; // szerokość trójkąta

            for (int i = 0; i < wysokosc; i++)
            {
                int liczbaPlusow = i * 2 + 1; // liczba znaków "+" w danym wierszu

                int liczbaSpacji = (szerokosc - liczbaPlusow) / 2; // liczba spacji przed znakami "+"

                // Wypisanie spacji przed znakami "+"
                for (int j = 0; j < liczbaSpacji; j++)
                {
                    Console.Write(" ");
                }

                // Wypisanie znaków "+"
                for (int j = 0; j < liczbaPlusow; j++)
                {
                    Console.Write("+");
                }

                Console.WriteLine(); // Przejście do kolejnego wiersza
            }
        }
    }
}
