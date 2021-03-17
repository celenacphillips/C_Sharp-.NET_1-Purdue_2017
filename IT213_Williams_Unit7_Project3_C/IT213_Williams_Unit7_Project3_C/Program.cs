using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit7_Project3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 40;

            Console.WriteLine(temp + " degrees Fahrenheit is " + celsius (temp) + " degrees Celsius");
            Console.WriteLine(temp + " degrees Celsius is " + fahrenheit(temp) + " degrees Fahrenheit");
        }

        private static int celsius (int myTemp)
        {
            return Convert.ToInt32((5.0 / 9.0 * (myTemp - 32)));
        }

        private static int fahrenheit (int myTemp)
        {
            return Convert.ToInt32((9.0 / 5.0 * myTemp + 32));
        }
    }
}
