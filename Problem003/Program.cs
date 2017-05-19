using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem003
{
    class Program
    {
        static void Main(string[] args)
        {
            long val = GetLargestPrimeFactor( 600851475143 );
            Console.WriteLine(val);
            Console.ReadLine();
        }


        private static long GetLargestPrimeFactor(long num)
        {
            long divisor = 1;

            long val;


            while (divisor < num) {

                if (num % divisor == 0) { // divides evenly

                    val = num / divisor;

                    if (IsPrime(val))
                        return val;
                }

                divisor++;
            }
            return -1;
        }


        private static bool IsPrime(long val) {


            for (int i = 2; i < Math.Sqrt(val); i++) {
                if (val % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
