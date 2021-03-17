using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit7_Project2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 20; num++)
            {
                if (isEven(num))
                    Console.WriteLine(num + " is an EVEN Integer");
                else
                    Console.WriteLine(num + " is an ODD Integer");
            }
        }

        private static Boolean isEven (int myNumber)
        {
            if (myNumber % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
