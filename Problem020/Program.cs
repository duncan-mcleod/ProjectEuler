using System;
using System.Diagnostics;
using System.Linq;

namespace Problem020 {
    class Program {
        static void Main(string[] args) {
            
            Stopwatch watch = Stopwatch.StartNew();
            
            long sum = SumDidgits(Factorial(100));

            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        private static long SumDidgits(string fact) {

            var i = from c in fact.ToCharArray()
                    select (int) char.GetNumericValue(c);

            return i.Sum();
        }



        //only works for small numbers
        private static string Factorial(int num) {

            string val = num.ToString();

            for (int i = num-1; i > 1; i--) {

                int d1 = i / 10;
                int d2 = i % 10;


                string num1 = Multiply(val, d1) + "0";
                string num2 = Multiply(val, d2);

                val = Add(num1, num2);
            }

            return val;
        }



        private static string Multiply(string s1, int c) {

            string result = string.Empty;

            int carryover = 0;

            foreach (char ch in s1.ToCharArray().Reverse()) {

                int val = c * (int) char.GetNumericValue(ch) + carryover;

                carryover = val / 10;

                val %= 10;

                result = val + result;
            }

            if ( carryover > 0 )
                result = carryover + result;

            return result;
        }

        private static string Add(string s1, string s2) {

            string val = string.Empty;

            int maxLength = Math.Max(s1.Length, s2.Length);
            s1 = Pad(s1, maxLength);
            s2 = Pad(s2, maxLength);
            

            int carryover = 0;
            for (int i = maxLength - 1; i >= 0; i--) {
                int num = (int)char.GetNumericValue(s1[i]) + (int)char.GetNumericValue(s2[i]) + carryover;


                val = (num % 10).ToString() + val;
                
                carryover = num / 10;
            }
            if (carryover > 0) {
                val = carryover.ToString() + val;
            }


            return val;
        }

        private static string Pad(string str, int maxLength) {
            if (str.Length < maxLength) {
                str = str.PadLeft(maxLength, '0');
            }

            return str;
        }
    }
}
