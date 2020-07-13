using System;
using System.Collections.Generic;
using System.Text;

namespace Übung
{
    class Class10
    {
        /*
        static void Main()
        {
            Console.WriteLine("Geben Sie die Anzahl der Messtage ein: ");
            int anz_messtage = Convert.ToInt32(Console.ReadLine());

            List<double> messung = new List<double>();
            for(int i = 0; i < anz_messtage; ++i)
            {
                Console.WriteLine("Geben Sie die Temperatur ein: ");
                messung.Add(Convert.ToDouble(Console.ReadLine()));
            }

            double maxtemp = double.MinValue;
            double mintemp = double.MaxValue;
            double tempdschnitt = 0;

            for(int i = 0; i < anz_messtage; ++i)
            {
                if(messung[i] > maxtemp)
                {
                    maxtemp = messung[i];
                }
                if(messung[i] < mintemp)
                {
                    mintemp = messung[i];
                }
                tempdschnitt += messung[i];
            }

            tempdschnitt = tempdschnitt / messung.Count;

            Console.WriteLine("Der Durchschnitt ist: " + tempdschnitt);
            Console.WriteLine("Die Höchsttemperatur ist: " + maxtemp);
            Console.WriteLine("Die Tiefsttemp ist: " + mintemp);

            Console.WriteLine("Die eingebenen Temperaturen sind: ");
            for(int i = 0; i < messung.Count; ++i)
            {
                Console.Write(messung[i] + " ");
            }

            Console.ReadKey();
        }*/
    }
}
