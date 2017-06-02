using System;

namespace Problem019 {
    class Program {
        static void Main(string[] args) {

            int count = 0;
            DateTime date = new DateTime(1901, 1, 1);
            DateTime endDate = new DateTime(2001, 1, 1);


            while (date < endDate) {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    count++;

                date = date.AddMonths(1);
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
