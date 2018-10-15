using System;
using System.Collections.Generic;
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
            int val = 0;
            int maxLength = 0;
            for ( int i = 2; i < 1000; i++ ) {
                List<int> remainders = new List<int>();
                int length = 0;
                int value = 1;

                while ( value > 0 && !remainders.Contains( value ) ) {
                    remainders.Add( value );
                    value *= 10;
                    value %= i;
                    length++;
                }
                if ( length > maxLength ) {
                    maxLength = length;
                    val = i;
                }
            }
            return val;
        }
    }
}