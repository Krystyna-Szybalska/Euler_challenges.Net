using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler2
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var Fibonacci = new List<int>();

            int n1 = 0;
            int n2 = 1;
            

            while  (n2 < 4000000)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;


                if (n2 % 2 == 0)
                {
                    Fibonacci.Add(n2);
                }
            }
        
            Console.WriteLine(Fibonacci.Sum());
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

            Console.ReadLine();
        
        }
    }
}
