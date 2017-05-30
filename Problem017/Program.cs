using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem017 {
    class Program {
        static void Main(string[] args) {

            int[] counts = new int[1001];

            counts[0] = 0;

            counts[1] = 3;
            counts[2] = 3;
            counts[3] = 5;
            counts[4] = 4;
            counts[5] = 4;
            counts[6] = 3;
            counts[7] = 5;
            counts[8] = 5;
            counts[9] = 4;



            counts[10] = 3;
            counts[11] = 6;
            counts[12] = 6;
            counts[13] = 8;
            counts[14] = 8;
            counts[15] = 7;
            counts[16] = 7;
            counts[17] = 9;
            counts[18] = 8;
            counts[19] = 8;



            counts[20] = 6;
            counts[30] = 6;
            counts[40] = 5;
            counts[50] = 5;
            counts[60] = 5;
            counts[70] = 7;
            counts[80] = 6;
            counts[90] = 6;


            for (int i = 21; i < 100; i++) {
                if (i % 10 != 0) {
                    counts[i] = counts[10 * (i / 10)] + counts[i % 10];
                }
            }



            counts[100] = 10;
            counts[200] = 10;
            counts[300] = 12;
            counts[400] = 11;
            counts[500] = 11;
            counts[600] = 10;
            counts[700] = 12;
            counts[800] = 12;
            counts[900] = 11;


            for (int i = 101; i < 1000; i++) {
                if (i % 100 != 0) {
                    counts[i] = counts[100 * (i / 100)] + counts[i % 100] + 3;
                }
            }




            counts[1000] = 11;




            Console.WriteLine(counts.Sum());
            Console.ReadLine();
        }
    }
}

