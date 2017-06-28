using System;
using System.IO;
using System.Linq;

namespace Problem022 {
    class Program {
        static void Main(string[] args) {

            var names = File.ReadAllText("p022_names.txt")
                            .Replace("\"", string.Empty)
                            .Split(new char[] { ',' })
                            .OrderBy(p => p)
                            .ToList();

            int total = 0;
            int pos = 0;
            names.ForEach(p => total += ++pos * GetScore(p));

            Console.WriteLine(total);
            Console.ReadKey();
        }


        private static int GetScore(string str) {

            int score = 0;
            foreach (char c in str) {
                score += c - 64;
            }

            return score;
        }
    }
}
