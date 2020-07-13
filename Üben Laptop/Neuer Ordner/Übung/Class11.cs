using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Übung
{
    class Class11
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie die Anzahl der Zeilen an: ");
            int zeilen = Convert.ToInt32(Console.ReadLine());

            int[,] koeffizient = new int[zeilen, zeilen];

            for(int i = 0; i < zeilen; ++i)
            {
                koeffizient[i, 0] = koeffizient[i, i] = 1;
            }

            for(int i = 1; i < zeilen-1; ++i)
            {
                for(int k = 1; k <=i; ++k)
                {
                    koeffizient[i + 1, k] = koeffizient[i, k - 1] + koeffizient[i, k];
                }
            }

            int breite = 5;
            for(int i = 0; i < zeilen; ++i)
            {
                int tiefe = (zeilen - i);
                Console.Write("{0," + breite * tiefe / 2 + "}", "");

                for(int k = 0; k <= i; ++k)
                {
                    Console.Write("{0," + breite + "}", koeffizient[i, k]);
                }
                Console.WriteLine();
            }

        }
    }
}
