using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Project1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five family names, then press 'Enter' after each one");

            String[] familyNames = new String[5];

            for (int i = 0; i < familyNames.Length; ++i)
            {
                familyNames[i] = Console.ReadLine();
            }

            Console.WriteLine("You entered the following family names:");

            for (int i = 0; i < familyNames.Length; ++i)
            {
                Console.WriteLine(familyNames[i]);
            }
        }
    }
}
