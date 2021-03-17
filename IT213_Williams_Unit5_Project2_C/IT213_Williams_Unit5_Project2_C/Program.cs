using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit5_Project2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 1;
            int counter = 1;

            while (counter <= 10)
            {
                if (number % 2 == 0.0)
                {
                    Console.WriteLine(number);
                }
                counter++;
                number++;
            }
        }
    }
}
