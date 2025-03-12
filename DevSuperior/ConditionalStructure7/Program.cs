using System;
using System.Globalization;

namespace ConditionalStructure7
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two numbers: ");

            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrant Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Quadrant Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Quadrant Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quadrant Q4");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("X-Axis");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Y-Axis");
            }
            else
            {
                Console.WriteLine("Origin");
            }
        }
    }
}