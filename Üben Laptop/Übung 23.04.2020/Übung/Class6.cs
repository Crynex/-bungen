using System;
using System.Collections.Generic;
using System.Text;

namespace Übung
{
    class Class6
    {

        bool Istungerade(int zahl) 
        {
            return (zahl % 2 == 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Die Zahl 5 ist ungerade? " + Istungerade(5)+"\n");
            Console.WriteLine(" Die Zahl 2 ist ungerade? " + Istungerade(2)+"\n");

        }
    
    }
}
