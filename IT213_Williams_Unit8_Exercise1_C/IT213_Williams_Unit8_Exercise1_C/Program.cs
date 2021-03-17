using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Exercise1_C
{
    class InitArray
    {
        static void Main(string[] args)
        {
            int[] array = new int [10];

            Console.WriteLine("{0}{1,8}", "Index", "value");

            for (int counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = counter;
                Console.WriteLine("{0,2}{1,8}", counter, array [counter]);
            }

            Console.ReadKey();
        }
    }
}
