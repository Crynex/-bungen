using System;
using System.Collections.Generic;
using System.Text;

namespace Übung_23._04._2020
{
    class Class9
    {
        /*
        static void VaterVon(int pos, string Name, List<string> Stammbaum)
        {
            int newpos = 2 * pos + 1;
            while (Stammbaum.Count - 1 < newpos) Stammbaum.Add(" ");
            Stammbaum[newpos] = Name;
        }

        static void MutterVon(int pos, string Name, List<string> Stammbaum)
        {
            int newpos = 2 + pos + 2;
            while (Stammbaum.Count - 1 < newpos) Stammbaum.Add(" ");
            Stammbaum[newpos] = Name;
        }

        static void Ausgabe(List<string> Stammbaum)
        {
            Ausgabe(0, Stammbaum);
        }
        static void Ausgabe(int pos, List<string> Stammbaum)
        {
            if (pos >= Stammbaum.Count) return;

            Console.WriteLine(Stammbaum[pos]);
            Ausgabe(2 * pos + 1, Stammbaum);
            Ausgabe(2 * pos + 2, Stammbaum);
        }

        static void Main()
        {
            List<string> Stammbaum = new List<string>() { "Hans" };

            VaterVon(0, "Michael", Stammbaum);
            MutterVon(0, "Ute", Stammbaum);

            VaterVon(1, "Richard", Stammbaum);
            MutterVon(1, "Beate", Stammbaum);

            VaterVon(2, "Uwe", Stammbaum);
            MutterVon(2, "Ulla", Stammbaum);

            Ausgabe(Stammbaum);
        }*/
    }
}
