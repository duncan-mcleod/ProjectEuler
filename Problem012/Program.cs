using System;

namespace Problem012 {
    class Program {
        static void Main( string[] args ) {

            int numFactors = 0;
            long currentTriangleNumber = 3;
            long currentNum = 2;

            while ( numFactors <= 500 ) {

                currentNum++;
                currentTriangleNumber += currentNum;

                numFactors = FindNumFactors( currentTriangleNumber );
            }

            Console.WriteLine( currentTriangleNumber );
            Console.ReadLine();
        }



        private static int FindNumFactors( long num ) {

            int count = 0;
            for ( long i = 1; i <= Math.Sqrt(num) ; i++ ) {
                if ( num % i == 0 )
                    count++;
            }

            int sqrt = (int) Math.Sqrt( num );
            bool sq = ( sqrt * sqrt == num );

            return count * 2 - (sq ? 1 : 0);
        }
    }
}
