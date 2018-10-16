using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problem029 {
    class Program {
        static void Main( string[] args ) {
            Stopwatch watch = Stopwatch.StartNew();
            var val = Solve();
            watch.Stop();
            Console.WriteLine( $"{val} - {watch.ElapsedMilliseconds}" );
            Console.ReadKey();
        }
        private static int Solve() {

            //Hashset removes duplicates
            HashSet<double> set = new HashSet<double>();

            for ( int a = 2; a <= 100; a++ ) {
                for ( int b = 2; b <= 100; b++) {

                    set.Add( Math.Pow( a, b ) );

                }
            }

            return set.Count;
        }
    }
}