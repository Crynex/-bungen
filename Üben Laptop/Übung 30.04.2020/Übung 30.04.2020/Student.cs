using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Übung_30._04._2020
{
    class Student
    {        

        /*
        public struct Studenten : IComparable<Studenten>
        {
            public string Name;
            public int Matrikelnummer;

            #region Equals;

            public override bool Equals(object obj)
            {
                return Equals((Studenten)obj)  && Equals((Studenten)obj);
            }

            public bool Equals(Studenten other)
            {
                return this.Matrikelnummer == other.Matrikelnummer;
            }

            public static bool operator ==( Studenten one, Studenten theother)
            {
                return one.Equals(theother);
            }

            public static bool operator !=( Studenten one, Studenten theother)
            {
                return !one.Equals(theother);
            }
            #endregion

            #region GetHashCode implementation
            public override int GetHashCode()
            {
                int hashCode = 0;
                unchecked
                {
                    if (Name != null)
                        hashCode += 1000000007 * Name.GetHashCode();

                    hashCode += 1000000009 * Matrikelnummer.GetHashCode();
                }
                return hashCode;
            }
            #endregion


            #region CompareTo

            public int CompareTo(Studenten other)
            {
                return other.Matrikelnummer == this.Matrikelnummer;
            }

            #endregion

            #region ToString
            public override string ToString()
            {
                return string.Format("[Student Name={0}, Matrikelnummer={1}]", Name, Matrikelnummer);
            }

            #endregion
        }

        static void Main()
        {
            Studenten s1, s2, s3, s4;

            s1.Name = "Ulla";
            s1.Matrikelnummer = 123;

            s2.Name = "Hans";
            s2.Matrikelnummer = 213;

            s3 = s1;

            s4.Name = "Michael";
            s4.Matrikelnummer = 123;

            List<Studenten> studis = new List<Studenten>()
            {
                s1,s2
            };


            if(s1 == s2)
            {
                Console.WriteLine("sind gleich");
            }
            else
            {
                Console.WriteLine("sind nicht gleich");
            }

            if (studis.Contains(s4))
            {
                Console.WriteLine("123 gefunden");
            }
            else
            {
                Console.WriteLine("Nichts gefunden");
            }

            studis.Sort();

            foreach(Studenten st in studis)
            {
                Console.WriteLine(st.Name);
            }

            Console.WriteLine(s1);

        }*/
    }
}
