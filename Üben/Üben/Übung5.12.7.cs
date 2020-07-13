using System;
using System.Collections.Generic;
using System.Text;

namespace Üben
{ 
    
    class Übung5
    {
        static void Main()
        {
            Console.WriteLine("Bitte geben Sie die Anzahl ein: ");
            int anz = 0;

            while (anz == 0)
            {
                anz = Convert.ToInt32(Console.ReadLine());
                if (anz == 0)
                {
                    Console.Write("Bitte geben Sie eine Zahl größer 0 ein.");
                }
            }

            Console.WriteLine("Bitte geben Sie die Zahlen ein: ");
            List<int> zahlen = new List<int>();

            for(int i = 0; i<anz; ++i)
            {
               zahlen.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int kleinstes = int.MaxValue;
            for (int i = 0; i < zahlen.Count; ++i)
            {
                if (zahlen[i] < kleinstes)
                {
                    kleinstes = zahlen[i];
                }
            }

            double summe = 0;
            for (int i = 0; i < zahlen.Count; ++i)
            {
                summe = summe + zahlen[i];
            }

            summe = summe / zahlen.Count;

            Console.WriteLine("Der Durschnitt ist: " + summe);
            Console.WriteLine("Die kleinste Zahl ist: " + kleinstes);
        }
        
    }

}
