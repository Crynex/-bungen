using System;
using System.Collections.Generic;
using System.Text;

namespace Übung
{
    class Class7
    {
        static void Main(string[] args)
        {
            ZeichneStrich();
            ZeichneStrich();
            ZeichneStrich();
        }

        static void ZeichneStrich()
        {
            int anz = 40;
            for (int i = 0; i < anz; ++i)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
