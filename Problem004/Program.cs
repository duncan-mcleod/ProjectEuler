using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 999;
            int n2 = 999;

            int val = n1 * n2;
            int max = 0;



            Console.WriteLine($"{906609}, {IsPalindromic(906609)}");
            //Console.WriteLine($"{998898}, {IsPalindromic(998898)}");
            //Console.WriteLine($"{99899}, {IsPalindromic(99899)}");
            //Console.WriteLine($"{948899}, {IsPalindromic(948899)}");


            while ( n1 > 99 ) {
                if (n2 == n1)
                {
                    n2 = 999;
                    n1--;
                }
                else
                {
                    n2--;
                }
                

                val = n1 * n2;
                if (val > max && IsPalindromic(val))
                {
                    max = val;
                }
                Console.WriteLine($"{val}, {n1}, {n2}");
            }

            Console.WriteLine($"{max}");
            Console.ReadLine();
        }



        private static bool IsPalindromic(int val) {

            var chars = val.ToString().ToCharArray();


            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] != chars[chars.Length - i - 1])
                    return false;
            }


            return true;
        }

    }
}
