using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges.NET
{
    class Euler9 //There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int suma = 1000;
            for (int a = 1; a < suma; a++)
            {
                for (int b = 1; b < suma; b++)
                {
                    int c = suma - a - b;

                    if ((a * a + b * b == c * c) && a < b)
                    {
                        Console.WriteLine(a * b * c);
                    }
                }
            }
            
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
