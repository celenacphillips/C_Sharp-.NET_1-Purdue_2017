using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit5_Project1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Score_John = 90, Score_Paul = 75;

            Console.Write ("Score_John = {0}\nScore_Paul = {1}\n\n", Score_John, Score_Paul);

            if (Score_John > Score_Paul)
                Console.WriteLine("John wins");
            else
                Console.WriteLine("Paul wins");
        }
    }
}
