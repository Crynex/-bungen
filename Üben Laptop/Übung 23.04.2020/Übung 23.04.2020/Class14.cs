using System;
using System.Collections.Generic;
using System.Text;

namespace Übung_23._04._2020
{
    class Class14
    {
        
        static int AnzZiffer(int zahl)
        {           
                return zahl.ToString().Length;            
        }

        static int SchnellAnzZiffer(int zahl)
        {
            if (zahl == 0) return 1;

            int anz = 0;
            while(zahl > 0)
            {
                ++anz;
                zahl /= 10;
            }

            return anz;
        }

        static int[] ziffern(int zahl)
        {
            int anz = SchnellAnzZiffer(zahl);

            int[] ergebnis = new int[anz];

            int pos = 0;
            int basis = 0;
            while(zahl > 0)
            {
                ergebnis[pos] = zahl & basis;
                zahl = zahl / basis;
                ++pos;
            }

            return ergebnis;
        }

        static void Main()
        {
            List<int> zahlen = new List<int>() { 12, 15, 231, 12314 };

            for(int i = 0; i < zahlen.Count; ++i)
            {
                Console.WriteLine(zahlen[i] + " : " + AnzZiffer(zahlen[i]));
                Console.WriteLine(zahlen[i] + " . " + SchnellAnzZiffer(zahlen[i]));
            }
        }
    }
}
