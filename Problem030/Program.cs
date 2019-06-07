using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem030 {
    class Program {
        static void Main( string[] args ) {
            Stopwatch watch = Stopwatch.StartNew();
            var val = Solve();
            watch.Stop();
            Console.WriteLine( $"{val} - {watch.ElapsedMilliseconds}ms" );
            Console.ReadKey();
        }
       


        private static int Solve() {

            int result = 0;

            for ( int i = 2; i < 355000; i++ ) {
                int sumOfPowers = 0;
                int number = i;
                while ( number > 0 ) {
                    int d = number % 10;
                    number /= 10;

                    int temp = d;
                    for ( int j = 1; j < 5; j++ ) {
                        temp *= d;
                    }
                    sumOfPowers += temp;
                }

                if ( sumOfPowers == i ) {
                    //Console.WriteLine( i );
                    result += i;
                }
            }
            return result;
        }
        
    }
}