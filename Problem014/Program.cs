using System;

namespace Problem014 {
    class Program {
        static void Main(string[] args) {
            int num = BruteForceCollatz();

            Console.WriteLine(num);
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
    }
}
