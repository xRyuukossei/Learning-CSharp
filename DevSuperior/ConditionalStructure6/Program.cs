using System;
using System.Globalization;

namespace ConditionalStructure6
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= 0 && n <= 25) 
            {
                Console.WriteLine("Interval [0,25]");
            }
            else if (n > 25 && n <= 50)
            {
                Console.WriteLine("Interval [25,50]");
            }
            else if (n > 50 && n <= 75)
            {
                Console.WriteLine("Interval [50,75]");
            }
            else if (n > 75 && n <= 100)
            {
                Console.WriteLine("Interval [75,100]");
            }
            else 
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}