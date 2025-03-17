using System;
using System.Globalization;

namespace ClassExercise2;
internal class Employee
{
    public string Name;
    public double GrossSalary;
    public double Tax;

    public double NetSalary()
    {
        return GrossSalary - Tax;
    }

    public void IncreaseSalary(double percent)
    {
        GrossSalary += GrossSalary/percent;
    }

    public override string ToString()
    {
        return "Employee: "
            + Name
            + ", $ "
            + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
    }
}
