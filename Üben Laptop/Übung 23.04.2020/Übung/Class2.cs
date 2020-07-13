using System;
using System.Collections.Generic;
using System.Text;

namespace Übung
{
    class Class2
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Anzahl ein: ");
            int anz = Convert.ToInt32(Console.ReadLine());
            ZeichneStrich(10, '+');
            ZeichneStrich(30, '*');
            ZeichneStrich(30, '!');
            ZeichneStrich(1, '#');

        }

        static void ZeichneStrich(int anz, char zeichen)
        {
            for (int i = 0; i < anz; ++i)
            {
                Console.Write(zeichen);
            }
            Console.WriteLine();
        }
    }
}
