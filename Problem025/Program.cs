using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Problem025 {
    class Program {
        static void Main(string[] args) {

            Stopwatch watch = Stopwatch.StartNew();

            BigInteger max = BigInteger.Pow(10, 999);  // 1000 digit number

            List<BigInteger> values = new List<BigInteger>();
            values.Add(1);
            values.Add(1);
            BigInteger value=1;
            int count=2;

            while (value <= max) {

                value = values[0] + values[1];
                values.Add(value);
                values.RemoveAt(0);
                count++;
            }

            watch.Stop();
            Console.WriteLine($"{count} - {watch.ElapsedMilliseconds}");
            Console.ReadKey();
        }
    }
}
