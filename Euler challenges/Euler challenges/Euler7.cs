using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler7 //What is the 10 001st prime number?
    {

        public static void Start()
        {
            List<long> primeFactors = new List<long>();


           while (primeFactors.Count <= 10000)
            {

                primeFactors.Add(primeFactor);
            }
                        
            Console.WriteLine($"The 10 001st prime number is {primeFactors[10000]});
        }

    }
}
