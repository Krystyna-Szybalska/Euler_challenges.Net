using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler5
    {
       public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int number = 20;
                  
            for (int i = 2; i < 20; i++)
           {
               if (number % i != 0)
               {
                    number += 20;
                    i = 2;
               }
           }

            Console.WriteLine(number);
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
            
        }
    }
}
