using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Exercise2_C
{
    class studentAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");

            int numStudents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer grade betwen 1 and 100 then press 'Enter'");

            int [] grades = new int[numStudents];
            double average = 0;

            for (int i = 0; i < grades.Length; ++i)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < grades.Length; ++i)
            {
                Console.WriteLine("Student {0}\t{1}", i, grades[i]);
                average += grades[i];
            }
            average /= grades.Length;

            Console.WriteLine("\nAverage:{0}", average);
        }
    }
}
