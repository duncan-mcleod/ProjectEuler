using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] fibs = GetEvenFiboNumbers();

            Console.WriteLine(fibs.Sum());
            Console.ReadLine();
        }


        static long[] GetEvenFiboNumbers()
        {
            List<long> valid = new List<long>();
            long n1 = 1, n2 = 2;

            valid.Add(n2);
            while (n2 < 4000000)
            {
                long next = n1 + n2;
                n1 = n2;
                n2 = next;
                

                if (n2 % 2 == 0)
                {
                    valid.Add(n2);
                }
                Console.WriteLine($"{n1}, {n2}");
            }

            return valid.ToArray<long>();
        }
    }
}
