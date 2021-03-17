using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit7_Project1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grades, followed by enter");
            Console.WriteLine("Enter -1 when done");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != -1)
            {
                Console.WriteLine("Quality point is " + qualityPoints(num));

                Console.WriteLine("\nEnter the grades, followed by enter");
                Console.WriteLine("Enter -1 when done");

                num = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int qualityPoints (int grade)
        {
            if (grade >= 90)
                return 4;
            else if (grade >= 80)
                return 3;
            else if (grade >= 70)
                return 2;
            else if (grade >= 60)
                return 1;
            else
                return 0;
        }
    }
}