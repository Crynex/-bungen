using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Übung
{
    class Class5
    {
        static void Main(string[] args)
        {
            
            Console.Write(Min(2, 5)+"\n");
            Console.Write(Min(2, 2)+"\n");
            Console.Write(Min(5, 1)+"\n");

            Console.Write(Max(2, 5)+"\n");
            Console.Write(Max(2, 10)+"\n");
            Console.Write(Max(5, 1)+"\n");
        }

        static int Min(int x, int y)
        {
            return (x < y) ? x : y;
        }

        static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}
