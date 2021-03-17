using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Project2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newTemperatures = new int[] {10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70};
            getTemperatures(newTemperatures);
        }

        private static void getTemperatures (int [] temperatures)
        {
            for (int i = 0; i < temperatures.Length; ++i)
            {
                Console.WriteLine("{0} degrees Fahrenheit is {1} degrees Celsius", temperatures[i], celsius(temperatures[i]));
                Console.WriteLine("{0} degrees Celsius is {1} degrees Fahrenheit", temperatures[i], fahrenheit(temperatures[i]));
            }
        }

        private static int celsius(int myTemp)
        {
            return Convert.ToInt32((5.0 / 9.0 * (myTemp - 32)));
        }

        private static int fahrenheit(int myTemp)
        {
            return Convert.ToInt32((9.0 / 5.0 * myTemp + 32));
        }
    }
}
