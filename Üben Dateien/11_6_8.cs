using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dateien_üben
{
    class _11_6_8
    {
        static void Main()
        {
            Console.Write("Geben Sie den Namen der datei an: ");
            string dname = Console.ReadLine();

            StreamReader st = new StreamReader(dname);

            string zeile;
            int anzahl = 0;

            while((zeile = st.ReadLine()) != null)
            {
                if (zeile.Length > 0 && zeile[0] == '0')
                    ++anzahl;
            }

            st.Close();

            Console.WriteLine("Die Anzahl ist der Zeilen {0}" + anzahl);
        }
    }
}
