using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit3_Exercise1_C
{
    class GradeBook
    {
        static void Main(string[] args)
        {
            DetermineClassAverage();
        }

        public static void DetermineClassAverage ()
        {
            int total = 0, gradeCounter = 1, grade, average;

            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade: ");

                grade = Convert.ToInt32(Console.ReadLine());
                total += grade;
                ++gradeCounter;
            }

            average = total / 10;

            Console.WriteLine("\nTotal of all 10 grades is {0}", total);
            Console.WriteLine("Class average is {0}", average);
            Console.ReadKey();
        }
    }
}
