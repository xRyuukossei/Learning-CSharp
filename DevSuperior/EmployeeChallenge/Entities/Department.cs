using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeChallenge.Entities;
internal class Department
{
    public string Name { get; set; }
    public int PayDay { get; set; }
    public Address Address { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();

    public Department() 
    {
    }
    public Department(string name, int payDay, Address address)
    {
        Name = name;
        PayDay = payDay;
        Address = address;
    }

    public void AddEmployee(Employee employee) 
    {
        Employees.Add(employee);
    }
    public void RemoveEmployee(Employee employee) 
    { 
        Employees.Remove(employee);
    }
    public double PayRoll() 
    {
        double totalToPay = 0.0;
        foreach (Employee emp in Employees) 
        {
            totalToPay += emp.Salary;
        }
        return totalToPay;
    }
}
