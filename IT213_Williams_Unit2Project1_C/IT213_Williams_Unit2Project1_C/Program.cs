using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit2Project1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 3, strokes = 4;

            if (par == strokes)
                Console.WriteLine("Score is equal to par");

            if (par > strokes)
                Console.WriteLine("Score is below par");
            else if (par < strokes)
                Console.WriteLine("Score is above par");
        }
    }
}
