using System;

namespace Problem007
{
    class Program
    {
        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        // What is the 10 001st prime number?
        static void Main(string[] args)
        {
            int cnt = 1;
            long val = 1;

            long ticks = DateTime.Now.Ticks;            

            while (cnt < 10001) {
                val+=2;
                if (IsPrime(val))
                    cnt++;
            }


            long ticks2 = DateTime.Now.Ticks;

            TimeSpan ts = new TimeSpan(ticks2 - ticks);

            Console.WriteLine($"Solution took {ts.TotalMilliseconds} milliseconds.");
            Console.WriteLine($"{val} is the {cnt} prime.");
            Console.ReadLine();
        }


        private static bool IsPrime(long val)
        {
            for (int i = 3; i <= Math.Sqrt(val); i+=2)
                if (val % i == 0)
                    return false;

            return true;
        }
    }
}
