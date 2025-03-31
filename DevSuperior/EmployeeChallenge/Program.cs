using EmployeeChallenge.Entities;
using System.Globalization;
using System;
using System.Numerics;

namespace EmployeeChallenge
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Department Name: ");
            string name = Console.ReadLine();
            Console.Write("Payment Date: ");
            int payDay = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("How many employees are in the department? ");
            int n = int.Parse(Console.ReadLine());

            Address address = new Address(email, phone);
            Department department = new Department(name, payDay, address);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee {i} Details:");
                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();
                Console.Write("Salary: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee = new Employee(nameEmployee, salaryEmployee);
                department.AddEmployee(employee);
            }

            ShowReport(department);
        }

        static void ShowReport(Department department) 
        {
            Console.WriteLine("\nPAYROLL:");
            Console.WriteLine("Sales Department = $" + department.PayRoll().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Payment made on " + department.PayDay);
            Console.WriteLine("Employees: ");
            foreach (Employee employee in department.Employees) 
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine("For any questions, please contact: " + department.Address.Email);
        }
    }
}