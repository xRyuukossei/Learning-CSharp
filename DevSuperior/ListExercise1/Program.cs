using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListExercise1
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            if (employees.Find(x => x.Id == idIncrease) == null) 
            {
                Console.WriteLine("This id dos not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double salaryIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Find(x => x.Id == idIncrease).IncreaseSalary(salaryIncrease);
            }

            Console.WriteLine("\nUpdated list of employees: ");

            foreach (Employee employee in employees) 
            {
                Console.WriteLine(employee.Id + ", " + employee.Name + ", " + employee.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}