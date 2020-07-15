using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dateien_üben
{
    class _11_6_6
    {
        /*
        static void Main()
        {
            //Datei anlegen
            Console.Write("Bitte geben Sie den Namen der Datei an: ");
            string dateiname = Console.ReadLine();

            //Datei schreiber
            StreamWriter writer = new StreamWriter(dateiname);

            //Eingaben
            Console.Write("Geben Sie Ihr Guthaben an: ");
            double kapital = Convert.ToDouble(Console.ReadLine());
            Math.Round(kapital, 2);

            Console.Write("Geben Sie den Zinsatz in % an: ");
            double zins = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie die Laufzeit in Jahren an: ");
            int jahre = Convert.ToInt32(Console.ReadLine());

            int jahr = 0;
            //Guthaben berechnen
            while(jahr <= jahre)
            {
                writer.WriteLine("{0,3}{1,10:f2}", jahr, kapital);
                kapital = kapital * (1.0 + (zins / 100.0));
                ++jahr;
            }               
            
            writer.Close();       

        }*/
    }
}
