using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit2_Exercise1_C
{
    class Comparison
    {
        static void Main (string [] args)
        {
            Console.Write("Enter the first integer: ");
            int number0 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number0 == number1)
                Console.WriteLine("{0} == {1}", number0, number1);

            if (number0 != number1)
                Console.WriteLine("{0} != {1}", number0, number1);

            if (number0 < number1)
                Console.WriteLine("{0} < {1}", number0, number1);

            if (number0 > number1)
                Console.WriteLine("{0} > {1}", number0, number1);
        }
    }
}
