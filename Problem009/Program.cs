using System;

namespace Problem009 {
    class Program {
        static void Main( string[] args ) {
            int a = 0, b = 0, c = 0;
            int s = 1000;
            bool found = false;
            for ( a = 1; a < s / 3; a++ ) {
                for ( b = a+1; b < s / 2; b++ ) {
                    c = s - a - b;

                    if ( a * a + b * b == c * c ) {
                        found = true;
                        break;
                    }
                }

                if ( found ) {
                    break;
                }
            }

            Console.WriteLine( $"{a}, {b}, {c}" );
            Console.WriteLine( a * b * c );
            Console.ReadLine();
        }
    }
}
