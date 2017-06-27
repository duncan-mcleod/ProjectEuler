using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem021 {
    class Program {
        static void Main(string[] args) {
            Stopwatch watch = Stopwatch.StartNew();
            Dictionary<int, int> sums = new Dictionary<int, int>();

            for (int i = 1; i <= 10000; i++) {
                int sum = 0;

                for (int j = 1; j <= i / 2; j++) {
                    if (i % j == 0) {
                        sum += j;
                    }
                }
                sums.Add(i, sum);
            }


            var pairs = from p1 in sums
                        join p2 in sums on new { Key1=p1.Key, Key2=p1.Value } equals new { Key1=p2.Value, Key2=p2.Key }
                        where p1.Key != p1.Value
                            && p1.Key < p2.Key
                        select p1.Key + p2.Key;
            int answer = pairs.Sum();
            watch.Stop();

            Console.WriteLine(answer);
            Console.WriteLine(watch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
