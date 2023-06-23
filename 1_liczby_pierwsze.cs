﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_liczby_pierwsze
{
    internal class Program
    {
        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                    return false;
            }

            return true;
        }
            static void Main(string[] args)
            {
                Console.Write("Podaj liczbę n: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Pierwsze {n} liczb:");

                int liczba = 2;
                int licznik = 0;

                while (licznik < n)
                {
                    if (CzyLiczbaPierwsza(liczba))
                    {
                        Console.WriteLine(liczba);
                        licznik++;
                    }
                    liczba++;
            }
        }
    }
}
