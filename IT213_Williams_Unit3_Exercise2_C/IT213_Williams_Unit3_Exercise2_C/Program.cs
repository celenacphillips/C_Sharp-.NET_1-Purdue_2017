using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit3_Exercise2_C
{
    class SumAndAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("I will compute the sum and average of all the numbers between 1 and 100.");

            int start = 1, stop = 100;

            int sum = Sum(start, stop);
            double average = Average(start, stop, sum);

            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine("The average is {0}", average);
        }

        private static int Sum (int low, int high)
        {
            int total = 0;

            for (int i = low; i <= high; i++)
            {
                total += i;
            }

            return total;
        }

        private static double Average (int low, int high, int sum)
        {
            double total = 0;

            for (int i = low; i <= high; i++)
            {
                total = sum / (double) i;
            }

            return total;
        }
    }
}
