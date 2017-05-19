using System;
using System.Collections;
using System.Diagnostics;

namespace Problem014 {
    class Program {
        static void Main(string[] args) {

            Stopwatch watch = Stopwatch.StartNew();
            int num = BruteForceCollatz();
            watch.Stop();
            Console.WriteLine($"{num} - {watch.Elapsed}");

            watch.Restart();
            num = OptimizedCollatz();
            watch.Stop();
            Console.WriteLine($"{num} - {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }

        

        private static int BruteForceCollatz() {

            int length = 0,
                maxLength = 0,
                maxVal = 0;


            for (int i = 2; i < 1000000; i++) {

                length = FindSequenceLength(i);
                //Console.WriteLine($"{i}\t{length}");
                if (length > maxLength) {
                    maxLength = length;
                    maxVal = i;
                }
            }

            return maxVal;
        }

        private static int FindSequenceLength(long num) {

            int length = 0;
            while (num != 1) {
                if (num % 2 == 0) { //even
                    num /= 2;
                } else { //odd
                    num = 3 * num + 1;
                }
                length++;
            }
            return length;
        }





        /**************************************   optimized   **************************************/
        
        private static int[] _values;

        private static int OptimizedCollatz() {

            _values = new int[1000000];

            int length = 0,
                maxLength = 0,
                maxVal = 0;


            for (int i = 2; i < 1000000; i++) {

                length = FindSequenceLengthOptimized(i);
                if (length > maxLength) {
                    maxLength = length;
                    maxVal = i;
                }
            }

            return maxVal;
        }



        private static int FindSequenceLengthOptimized(long num) {

            int length = 0;
            long tmp = num;

            while (tmp != 1) {

                if (tmp < 1000000 && _values[tmp] > 0) {
                    length += _values[tmp];
                    break;
                }

                if (tmp % 2 == 0) { //even
                    tmp /= 2;
                } else { //odd
                    tmp = 3 * tmp + 1;
                }
                length++;
            }


            _values[num] = length;
            return length;
        }
    }
}
