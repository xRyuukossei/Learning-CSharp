using System;
using System.Globalization;

namespace SequentialStructure4
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your employee number: ");
            int employee = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of hours worked: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly wage: ");
            double hourlyWage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + employee);
            Console.WriteLine("SALARY = U$ " + (hoursWorked * hourlyWage).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}