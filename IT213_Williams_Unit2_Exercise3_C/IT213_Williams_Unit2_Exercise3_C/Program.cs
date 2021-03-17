using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit2_Exercise3_C
{
    class GradeComparison
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 60)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");
        }
    }
}
