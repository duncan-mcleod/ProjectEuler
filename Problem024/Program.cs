using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problem024 {
    class Program {
        static void Main(string[] args) {

            Stopwatch watch = Stopwatch.StartNew();
            var val = GetMillionthPermutation();


            watch.Stop();
            Console.WriteLine($"{val} - {watch.ElapsedMilliseconds}");
            Console.ReadKey();
        }



        private static string GetMillionthPermutation() {

            int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int N = perm.Length;
            string permNum = "";
            int remain = 1000000 - 1;

            List<int> numbers = new List<int>();
            for (int i = 0; i < N; i++) {
                numbers.Add(i);
            }

            for (int i = 1; i < N; i++) {
                int j = remain / Factorial(N - i);
                remain = remain % Factorial(N - i);
                permNum = permNum + numbers[j];
                numbers.RemoveAt(j);
                if (remain == 0) {
                    break;
                }
            }

            for (int i = 0; i < numbers.Count; i++) {
                permNum = permNum + numbers[i];
            }
            return permNum;
        }




        private static int Factorial(int i) {
            if (i <= 0) {
                return 0;
            }

            int p = 1;
            for (int j = 1; j <= i; j++) {
                p *= j;
            }
            return p;
        }
    }



}



