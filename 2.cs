using System;
namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 1;
            double S, V, pi = 3.14;
            S = 4 * pi * Math.Pow(r, 2);
            V = (4 * pi * Math.Pow(r, 3)) / 3;
            Console.WriteLine("\nSquare=" + S);
            Console.WriteLine("\nV=" + V);
            Console.ReadKey();
        }

    }
}

