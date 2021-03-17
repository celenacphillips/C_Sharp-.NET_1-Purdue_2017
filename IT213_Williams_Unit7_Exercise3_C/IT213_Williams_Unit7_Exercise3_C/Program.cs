using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit7_Exercise3_C
{
    class AverageAndSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers, each followed by 'Enter'");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average is " + averageThree(num1, num2, num3));
            Console.WriteLine("The sum is " + sumThree(num1, num2, num3));
        }

        private static int averageThree(int x, int y, int z)
        {
            int average = (x + y + z) / 3;

            return average;
        }

        private static int sumThree (int x, int y, int z)
        {
            return (x + y + z);
        }
    }
}
