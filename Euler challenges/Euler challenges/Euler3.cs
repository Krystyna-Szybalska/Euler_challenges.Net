using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler3
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long number = 600851475143;
            int Dzielnik = 2;

            while (number != 1)
            { 
                if (number % Dzielnik == 0)

                {
                    number /= Dzielnik;
                }
                else
                {
                    Dzielnik += 1;
                }
                
            }
            Console.WriteLine(Dzielnik);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }

    }
}
