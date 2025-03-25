using System;

namespace ListExercise1;
internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee (int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void IncreaseSalary(double percent)
    {
        Salary += (Salary * percent / 100);
    }


}
