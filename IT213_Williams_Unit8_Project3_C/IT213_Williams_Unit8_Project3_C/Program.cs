using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit8_Project3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengerCount = 3;
            String[] names = new String [passengerCount], sections = new String [passengerCount];
            int count = 0;

            while (count < passengerCount)
            {
                Console.WriteLine("\n\nEnter the passenger's name then press 'Enter'");
                names[count] = Console.ReadLine();

                Console.WriteLine("\nEnter 'F' for First Class");
                Console.WriteLine("Enter 'E' for Economy");
                Console.WriteLine("Then press 'Enter'");

                if (Console.ReadLine().Equals("F"))
                    sections[count] = "First Class";
                else
                    sections[count] = "Economy";

                ++count;
            }

            for (int i = 0; i < passengerCount; ++i)
            {
                Console.WriteLine("Passenger: {0} is in {1}", names[i], sections[i]);
            }
        }
    }
}
