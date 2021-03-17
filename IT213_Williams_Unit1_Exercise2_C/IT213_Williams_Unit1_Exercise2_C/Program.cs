using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit1_Exercise2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String numberString = "20";
            int number = Convert.ToInt32(numberString);

            int number2 = 10;

            Console.WriteLine("The variable number (" + number + ") divided by number2 (" + 
                              number2 +") is equal to " + (number / number2) + ".");
        }
    }
}
