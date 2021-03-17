using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit2Project2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = 5;
            String day = "";

            switch (dayNumber) {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day = "NULL";
                    break;
            }

            Console.WriteLine("The day of the week is " + day);
        }
    }
}
