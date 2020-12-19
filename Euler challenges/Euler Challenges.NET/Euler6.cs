using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges.NET
{
    class Euler6
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<int> Squares = new List<int>();
            List<int> Sums = new List<int>();
        

            for (int i = 1; i < 101; i++)
            {
                var square = i * i;
                Squares.Add(square);
            }


            for (int i = 1; i < 101; i++)
            {
                Sums.Add(i);
            }

            var suma = Sums.Sum();
            var squareOfSums = suma * suma;
            var sumOfSquares = Squares.Sum();

            var difference =  squareOfSums - sumOfSquares;

           
            Console.WriteLine(difference);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }

    }
}
