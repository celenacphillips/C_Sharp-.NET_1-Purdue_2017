using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit1Project_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, address, city, state, zipCode, userName, pin, tutitionOwed;
            int numberUnitsTaken;
            const int CostPerUnit = 100;

            name = "John Smith";
            address = "101 n. Main Street";
            city = "Anytown";
            state = "TX";
            zipCode = "11111";
            numberUnitsTaken = 18;

            Console.WriteLine ("Name: " + name);
            Console.WriteLine ("Address: " + address);
            Console.WriteLine ("City: " + city);
            Console.WriteLine ("State: " + state);
            Console.WriteLine ("Zip Code: " + zipCode);
            Console.WriteLine ("The tuition you owe is " + 
                (numberUnitsTaken*CostPerUnit).ToString("C", CultureInfo.CurrentCulture) + ".");
        }
    }
}
