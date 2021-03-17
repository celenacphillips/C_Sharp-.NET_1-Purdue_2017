using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit1_Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25, num2 = 5;

            Console.WriteLine(num1 + " - " + num2 + " = " + (num1-num2));
            Console.WriteLine(num2 + " - " + num1 + " = " + (num2-num1));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1*num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1/num2));
            Console.WriteLine(++num1);
            Console.WriteLine(--num2);
        }
    }
}
