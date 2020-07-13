using System;
using System.Collections.Generic;
using System.Text;

namespace Übung
{
    class Class1
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Anzahl ein: ");
            int anz = Convert.ToInt32(Console.ReadLine());
            ZeichneStrich(anz);
            ZeichneStrich(anz);
            ZeichneStrich(anz);
        }

        static void ZeichneStrich(int anz)
        {
           for (int i = 0; i < anz; ++i)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
    }
}
