using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_challenges
{
    class Euler4
    {
        public static void Start()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int Maxpalindrom = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    int sum = i * j;
                    string palindrom = sum.ToString();
                    string mordnilap = new string(palindrom.Reverse().ToArray());
                   
                    if (palindrom == mordnilap)
                    {
                        if (sum>Maxpalindrom)
                        {
                            Maxpalindrom = sum;
                        }

                    }
                }
            }

            Console.WriteLine(Maxpalindrom);
            
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

            Console.ReadLine();
        }
    }  
}
