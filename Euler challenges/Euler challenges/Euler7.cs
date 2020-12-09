using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler7 //What is the 10 001st prime number?
    {

        public static void Start()
        {
           
            
            Stopwatch stopwatch = Stopwatch.StartNew();

            int primeFactor = 2;
            int counter = 1;

            while (counter < 10001)
            {
                primeFactor++;

                if (IsPrime(primeFactor))
                {
                    counter++;
                }

            }

            Console.WriteLine($"The 10 001st prime number is {primeFactor}");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

        }
        public static bool IsPrime(int number)
        {
            for (int j = 2; j < Math.Sqrt(number) + 1; j++)
            {
                if (number % j == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
