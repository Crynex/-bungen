using System;
using System.Collections.Generic;

namespace Übung_30._04._2020
{
    
    public struct Konto
    {
        public double KontoStand;
        public string Besitzer;

        /*
        public Konto(string derBesitzer)
        {
            this.KontoStand = 0;
            this.Besitzer = derBesitzer;
        }
        public Konto(string derBesitzer, double derKontoStand)
        {
            this.Besitzer = derBesitzer;
            this.KontoStand = derKontoStand;
        }


        public static void Einzahlen(ref Konto dasKonto, double betrag)
        {
            dasKonto.KontoStand = dasKonto.KontoStand + betrag;
        }
        public void Einzahlen(double betrag)
        {
            this.KontoStand = this.KontoStand + betrag;
        }

        public void Auszahlen(double betrag)
        {
            this.Einzahlen(-betrag);
        }

        public override string ToString()
        {
            return "Konto: " +
                this.Besitzer + "; Konstostand: " + this.KontoStand;
        }*/

    }

    class MeinProgramm
    {
        /*
        public static double DurchschnittsKontoStand(List<Konto> ktn)
        {
            if (ktn.Count == 0) return 0;

            double summe = 0;
            foreach(Konto kt in ktn)
            {
                summe = summe + kt.KontoStand;
            }

            return summe/ ktn.Count;
        }
        static void Main()
        {
            List<Konto> meineKonten = new List<Konto>();

            meineKonten.Add(new Konto("Hans", 100));
            meineKonten.Add(new Konto("Ulla"));
            meineKonten.Add(new Konto("Beate", 200));

            foreach(Konto kt in meineKonten)
            {
                Console.WriteLine(kt);
            }

            Console.WriteLine("Durschnittstand: " + DurchschnittsKontoStand(meineKonten));
        }*/

    }
}
