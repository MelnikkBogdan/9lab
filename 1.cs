using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 1, y = 0, z = 0, a = 0;
            while (x != 0)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                z = double.Parse(Console.ReadLine());
                a = Math.Atan(y + z) * Math.Pow(Math.Pow(y, 2) + 4, 2);
                if (x < -1 && x > -10)
                { Console.WriteLine($"\n���� �� -1"); }
                if (x < -10)
                {
                    Console.WriteLine($"\n���� �� -10");
                }
                if (x > 10)
                {
                    Console.WriteLine($"\n���� �� 10");
                }
                if (x > 1 && x < 10)
                {
                    Console.WriteLine($"\n���� �� 1");
                }
                Console.WriteLine(a);


                string rez = (a < 0) ? "negative" : "positive";
                Console.WriteLine($"\nRezult is {rez}");
            }
        }
    }

