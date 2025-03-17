using System;
using System.Globalization;

namespace ClassExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(employee);

            Console.Write("Enter the percentage to increase the salary: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(percent);

            Console.WriteLine("Updated data: " + employee);
        }
    }
}