using System;
using System.Globalization;

namespace SequentialStructure6
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three floating-point values: ");

            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Triangle: " + (a * c / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circle: " + (Math.PI * c * c).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezoid:" + (((a + b) * c) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Square: " + (b * b).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Rectangle: " + (a * b).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}