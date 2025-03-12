using System;
using System.Globalization;

namespace SequentialStructure
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A=" + (Math.PI * r * r).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}