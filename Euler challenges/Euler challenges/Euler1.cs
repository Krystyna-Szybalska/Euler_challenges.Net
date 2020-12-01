
using System;
using System.Diagnostics;

namespace Euler_challenges
{
    class Euler1
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int suma = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }

    }

}
