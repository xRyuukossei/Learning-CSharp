using System;
using System.Globalization;

namespace ConditionalStructure8
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.00)
            {
                Console.WriteLine("Exempt");
            }
            else if (salary > 2000.00 && salary <= 3000.00)
            {
                Console.WriteLine("R$ " + ((salary - 2000.00) * 0.08).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salary > 3000.00 && salary <= 4500.00)
            {
                Console.WriteLine("R$ " + ((salary - 3000.00) * 0.18 + (1000.00 * 0.08)).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ " + ((salary - 4500.00) * 0.28 + (1500.00 * 0.18) + (1000.00 * 0.08)).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}