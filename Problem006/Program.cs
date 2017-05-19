using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareOfSums(100) - SumOfSquares(100));

            Console.WriteLine("Done.");
            Console.ReadLine();
        }




        private static long SumOfSquares(int val)
        {
            if (val == 1) return 1;
            return val * val + SumOfSquares(val - 1);
        }


        private static long SquareOfSums(int val)
        {
            long sum = 0;

            for (int i = 1; i <= val; i++)
                sum += i;

            return sum * sum;
        }
    }
}
