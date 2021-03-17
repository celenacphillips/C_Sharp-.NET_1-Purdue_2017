using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Exercise3_C
{
    class ArrayAverage
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {25, 5, 48, 34,1, 15};
            double average = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                average += numbers[i];
            }
            average /= numbers.Length;

            Console.WriteLine("Average: {0}", average);
        }
    }
}
