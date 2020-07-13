using System;
using System.Collections.Generic;
using System.Text;

namespace Übung_30._04._2020
{
    class Rad
    {
        public struct RadTyp
        {
            public double Durchmesser;
            public int Gewicht;
            public string Hersteller;

            public void Ausgeben()
            {
                Console.WriteLine("Rad[ Durchmesser " + this.Durchmesser + " Gewicht " + this.Gewicht + " Hersteller " + this.Hersteller + "]");
            }
        }

        

        class Beispiel
        {
            static void Main()
            {
                RadTyp r1 = new RadTyp();
                r1.Durchmesser = 40.5;
                r1.Gewicht = 2785;
                r1.Hersteller = "Michelin";

                RadTyp r2 = new RadTyp();
                r2.Durchmesser = 39.3;
                r2.Gewicht = 2595;
                r2.Hersteller = "Dunlop";

                RadTyp r3 = new RadTyp();
                r3.Durchmesser = 42.0;
                r3.Gewicht = 2850;
                r3.Hersteller = "Bridgestone";

                r1.Ausgeben();
                r2.Ausgeben();
                r3.Ausgeben();
            }
        }
    }
}
