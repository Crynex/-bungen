using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dateien_üben
{
    class _11_6_9
    {
        static void Main()
        {
            string dname = "gleitpunkt";

            StreamReader st = new StreamReader(dname);

            double summe = 0.0;

            string zeile;

            while((zeile=st.ReadLine()) != null)
            {
                summe += Convert.ToDouble(zeile);
            }

            st.Close();
            Console.WriteLine("Die Summe der Zahlen ist {0}", summe);
        }
    }
}
