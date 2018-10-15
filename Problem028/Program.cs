using System;
using System.Diagnostics;

namespace Problem026 {
    class Program {
        static void Main( string[] args ) {
            Stopwatch watch = Stopwatch.StartNew();
            var val = Solve();
            watch.Stop();
            Console.WriteLine( $"{val} - {watch.ElapsedMilliseconds}" );
            Console.ReadKey();
        }
        private static int Solve() {

            int sum = 1;

            for ( int i = 3; i <= 1001; i+=2 ) {

                sum += i * i +                      //TR
                       i * i - ( i - 1 ) +          //TL
                       i * i - 2 * ( i - 1 ) +      //BL
                       i * i - 3 * ( i - 1 );       //BR
            }

            return sum;
        }
    }
}