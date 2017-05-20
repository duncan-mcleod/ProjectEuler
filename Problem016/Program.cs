using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem016 {
    class Program {

        //Sum of digits in 2^1000
        static void Main(string[] args) {

            int[] nums = new int[1000];
            nums[0] = 1;

            int carry = 0;

            for (int i = 1; i <= 1000; i++) {

                for (int j = 0; j < 1000; j++) {
                    int val = 2 * nums[j] + carry;
                    carry = (val > 9) ? val/10 : 0;
                    nums[j] = val % 10;
                }
                //if (i < 32) {
                //    Console.Write($"{i} - ");
                //    for (int x = 0; x < 100; x++) {
                //        Console.Write(nums[x]);
                //    }
                //    Console.WriteLine();
                //}

            }
            Console.WriteLine(nums.Sum());
            Console.ReadLine();
        }
    }
}
