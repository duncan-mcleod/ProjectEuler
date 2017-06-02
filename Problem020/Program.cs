using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem020 {
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine(Factorial(100));
            Console.ReadKey();
        }



        //only works for small numbers
        private static long Factorial(long num) {

            return num == 1 ? 1 : num * Factorial(num - 1);
        }



        private string Multiply(string s1, string s2) {

            int index = 0;
            int carry = 0;

            return "";
        }

        private string Add(string s1, string s2) {

            int index = 0;
            int carry = 0;

            return "";
        }
    }
}
