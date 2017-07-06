using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem023 {
    class Program {
        static void Main(string[] args) {

            Stopwatch watch = Stopwatch.StartNew();
            var abundant = GetAbundantNumbers();

            int sum = GetNotSumOfTwoAbundantNumbers(abundant);

            watch.Stop();
            Console.WriteLine($"{sum} - {watch.ElapsedMilliseconds}");
            Console.ReadKey();
        }



        private static IEnumerable<int> GetAbundantNumbers() {

            List<int> nums = new List<int>();

            for (int i = 1; i <= 28123; i++) {
                int sum = GetSumFactors(i);

                if (sum > i)
                    nums.Add(i);
            }

            return nums;
        }

        private static int GetSumFactors(int num) {
            int sum = 0;

            for (int i = 1; i <= num / 2; i++) {
                if (num % i == 0)
                    sum += i;
            }
            
            return sum;
        }


        private static int GetNotSumOfTwoAbundantNumbers(IEnumerable<int> abundants) {

            // all possible sums of 2 abundant numbers
            var c = from a1 in abundants
                    from a2 in abundants 
                    select a1 + a2;

            c = c.Distinct().Where( p => p <= 28123);

            var integers = Enumerable.Range(1, 28123);


            var notSums = integers.Except(c);


            return notSums.Sum();
        }
    }
}
