using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Übung
{
    class Class4
    {
        static void Main()
        {
            Console.WriteLine(Abs(3));
            Console.WriteLine(Abs(0));
            Console.WriteLine(Abs(-5));
        }

        static int Abs(int zahl)
        {
            if (zahl < 0)
            {
                return -zahl;
            }else
            {
                return zahl;
            }
        }
    }
}
