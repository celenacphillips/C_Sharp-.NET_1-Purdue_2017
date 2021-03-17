using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit5_Project3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence = "The quick brown fox jumps over the lazy dog";

            String[] splitSentence = sentence.Split(' ');
            int wordCount = 0;
            foreach (var token in splitSentence)
            {
                wordCount++;
                Console.WriteLine(wordCount + " " + token);
            }

            Console.WriteLine("\nTotal of {0} words.", wordCount);
        }
    }
}
