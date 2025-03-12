using System;
using System.Globalization;

namespace ForStructure3
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3 real numbers, each with one decimal place");

            for (int i = 0; i < n; i++) 
            {
                string[] v = Console.ReadLine().Split(' ');
                double v1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                double average = ((v1 * 2.0) + (v2 * 3.0) + (v3 * 5.0)) / 10.0;
                Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}