using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit3Project1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;

            while (k >= 1)
            {
                int i = 0;

                while (i <= 10)
                { 
                    Console.WriteLine("k = {0} i = {1}", k, i);

                    i += 2;
                }
                --k;
            }
        }
    }
}
