using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dateien_üben
{
    class _11
    {
        /*
        public static void Main()
        {    
            
            //Dateiname & anlegen
            Console.Write("Geben Sie den Namen der Datei an: ");
            string dateiname = Console.ReadLine();            

            //Datei öffnen schreiber
            StreamWriter writer = new StreamWriter(dateiname);

            //Liste zahlen
            List<int> zahlen = new List<int>();

            //Anzahl zahlen
            Console.Write("Bitte geben Sie eine Anzahl ein: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Zahlen einlesen
            for (int i = 0; i < anzahl; ++i)
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
                zahlen.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
            }         

            //Schreiben           
            for (int i = 0; i < zahlen.Count; ++i)
            {
                writer.WriteLine(zahlen[i]);
            }
            writer.Close();

            //Datei öffnen leser
            StreamReader reader = new StreamReader(dateiname);

            //Liste gelesen
            List<int> _zahlen = new List<int>();

            //Lesen
            for(int i = 0; i<anzahl; ++i)
            {
                string zeile = reader.ReadLine();
                int zahl = Convert.ToInt32(zeile);
                _zahlen.Add(zahl);
            }       

            //Schließen
            reader.Close();

            //Ausgeben gelesen
            foreach(int zahl in _zahlen)
            {
                Console.WriteLine(zahl);
            }
          
        }*/
    }
}
