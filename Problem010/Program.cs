using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Problem010 {
    class Program {
        static void Main( string[] args ) {
            const int upperBounds = 2000000;

            // Brute Force
            Stopwatch watch = Stopwatch.StartNew();
            long sum = BruteForceSolution.GetSumOfPrimes( upperBounds );
            watch.Stop();
            Console.WriteLine( $"Brute force solution: {sum} Time: {watch.ElapsedMilliseconds}" );

            // Sieve Algorithm
            watch = Stopwatch.StartNew();
            sum = SieveSolution.GetSumOfPrimes( upperBounds );
            watch.Stop();
            Console.WriteLine( $"Sieve solution: {sum} Time: {watch.ElapsedMilliseconds}" );
            Console.ReadLine();
        }


        private static bool IsPrime( long val ) {
            for ( int i = 3; i <= Math.Sqrt( val ); i += 2 )
                if ( val % i == 0 )
                    return false;

            return true;
        }
    }



    static class BruteForceSolution {
        public static long GetSumOfPrimes( int upperBounds ) {

            long sum = 2;

            for ( int i = 3; i < upperBounds; i += 2 ) {
                if ( IsPrime( i ) )
                    sum += i;
            }
            return sum;
        }


        private static bool IsPrime( long val ) {
            for ( int i = 3; i <= Math.Sqrt( val ); i += 2 )
                if ( val % i == 0 )
                    return false;

            return true;
        }
    }




    static class SieveSolution {

        public static long GetSumOfPrimes(int upperBounds) {

            // bit array initialized to true
            // I ignore the 0 and 1 indexes, start at first prime which is 2, makes code easier to read and understand
            BitArray bits = new BitArray( upperBounds+1, true );   

            for ( int i = 2; i <= upperBounds; i++ ) {

                //if number is prime, mark all multiples as not prime, skip non prime numbers
                if ( bits[i] == true ) {  
                    for ( int j = 2*i; j <= upperBounds; j += i ) {
                        bits[j] = false;
                    }
                }
            }

            // add them all up
            long sum = 0;
            for ( int i = 2; i <= upperBounds; i++ ) {
                if ( bits[i] == true ) {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
