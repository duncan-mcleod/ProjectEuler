using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            long[] primes = SievePrimes.GetPrimes( 87400 );


            int aMax = 0, bMax = 0, nMax = 0;


            for ( int a = -1000; a <= 1000; a++ ) {
                for ( int b = -1000; b <= 1000; b++ ) {
                    int n = 0;
                    while ( IsInPrimeList( Math.Abs( n * n + a * n + b ), primes ) ) {
                        n++;
                    }
                    if ( n > nMax ) {
                        aMax = a;
                        bMax = b;
                        nMax = n;
                    }
                }
            }



            return aMax * bMax;
        }



        private static bool IsInPrimeList( long l, long[] primes ) {

            int i = 0;
            while ( primes[i] <= l ) {
                if ( primes[i] == l ) {
                    return true;
                }
                i++;
            }
            return false;
        }
    }




    static class SievePrimes {

        public static long[] GetPrimes( int upperBounds ) {

            // bit array initialized to true
            // I ignore the 0 and 1 indexes, start at first prime which is 2, makes code easier to read and understand
            BitArray bits = new BitArray( upperBounds + 1, true );

            for ( int i = 2; i <= upperBounds; i++ ) {

                //if number is prime, mark all multiples as not prime, skip non prime numbers
                if ( bits[i] == true ) {
                    for ( int j = 2 * i; j <= upperBounds; j += i ) {
                        bits[j] = false;
                    }
                }
            }

            List<long> primes = new List<long>();
            for ( int i = 2; i <= upperBounds; i++ ) {
                if ( bits[i] == true ) {
                    primes.Add( i );
                }
            }

            return primes.ToArray();
        }
    }
}
