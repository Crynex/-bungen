using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Übung_30._04._2020
{
    /*
    class Überweisung : IComparable<Überweisung>
    {
        private static int objNo = 0;

        public int Nummer;
        public DateTime Datum;
        public string Urheber;
        public double Überweisungssumme;


        #region Konstruktoren

        public Überweisung()
        {
            Nummer = ++objNo;
            Datum = DateTime.Now;
            Urheber = "MM";
            Überweisungssumme = 0.0;
        }

        public Überweisung(string nm, double summe)
        {
            Nummer = ++objNo;
            Datum = DateTime.Now;
            Urheber = nm;
            Überweisungssumme = summe;
        }

        #endregion

        #region Equals and GetHashCode implementation

        public override bool Equals(object obj)
        {
            Überweisung other = obj as Überweisung;
            if (other == null)
                return false;
            return this.Nummer == other.Nummer && this.Datum == other.Datum && this.Urheber == other.Urheber && this.Überweisungssumme == other.Überweisungssumme;
        }

        public override int GetHashCode()
        {
            int HashCode = 0;
            unchecked
            {
                HashCode += 1000000007 * Nummer.GetHashCode();
                HashCode += 1000000009 * Datum.GetHashCode();
                if (Urheber != null)
                    HashCode += 1000000021 * Urheber.GetHashCode();
                HashCode += 1000000033 * Überweisungssumme.GetHashCode();
            }
            return HashCode;
        }

        public static bool operator ==(Überweisung lhs, Überweisung rhs)
        {
            if (ReferenceEquals(lhs, rhs)) return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) return false;
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Überweisung lhs, Überweisung rhs)
        {
            return !(lhs == rhs);
        }

        #endregion

        #region CompareTo

        public int CompareTo(Überweisung other)
        {
            int res = this.Datum.CompareTo(other.Datum);
            if (res != 0) return -res;

            res = this.Urheber.CompareTo(other.Urheber);
            if (res != 0) return res;

            return (int)(other.Überweisungssumme - this.Überweisungssumme);
        }

        #endregion

        #region ToString
        public override string ToString()
        {
            return string.Format("[Überweisung Nummer = {0}, Datum = {1}, Urheber = {2}, Überweisungssumme = {3}]", Nummer, Datum, Urheber, Überweisungssumme); 
        }
        #endregion
    }


    class Program
    {
        public static void Main()
        {
            List<Überweisung> ubw = new List<Überweisung>()
            {
                new Überweisung(),
                new Überweisung("Hans", 10000),
                new Überweisung("Beate", 100),
                new Überweisung("Hans", 2000),
            };

            ubw.Sort();
            foreach(Überweisung uu in ubw)
            {
                Console.WriteLine(uu);
            }
        }
    }*/
}
