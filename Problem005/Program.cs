using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem005
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 1;
            for (int i = 2; i <= 20; i++)
            {
                x = lcm(x, i);
                Console.WriteLine($"{i}, {x}");
            }

            Console.WriteLine(x);

            Console.WriteLine("Done.");
            Console.ReadLine();
        }





        private static long Factorial(long val)
        {
            if (val < 1) throw new ArgumentOutOfRangeException(nameof(val));
            if (val == 1) return 1;
            return val * Factorial(val - 1);
        }



        private static long gcd(long a, long b)
        {
            return (b == 0) ? a : gcd(b, a % b);
        }

        private static long lcm(long a, long b)
        {
            return ((a * b) / gcd(a, b));
        }
    }
}
