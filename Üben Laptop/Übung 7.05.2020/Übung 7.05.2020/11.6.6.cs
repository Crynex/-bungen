using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Übung_7._05._2020
{
    class _11
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie den Dateinamen an: ");
            string dateiname = Console.ReadLine();

            Console.Write("Bitte geben Sie das Startkapital ein: ");
            double kapital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie den Zins in % ein: ");
            double zins = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Laufzeit in Jahren an: ");
            int laufzeit = Convert.ToInt32(Console.ReadLine());

            StreamWriter writer = new StreamWriter(dateiname);

            int jahr = 0;
            while (jahr <= laufzeit)
            {
                writer.WriteLine()
            }
        }
    }
}
