using System;
using System.Globalization;

namespace ExerciseOOP2
{
	class Program
	{
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            
            Console.WriteLine("First employee's data");

            Console.Write("Name: ");
            e1.name = Console.ReadLine();

            Console.Write("Salary: ");
            e1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second employee's data");

            Console.Write("Name: ");
            e2.name = Console.ReadLine();

            Console.Write("Salary: ");
            e2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Average salary: " + ((e1.salary + e2.salary) / 2).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}