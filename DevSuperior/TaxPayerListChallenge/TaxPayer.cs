using System;

namespace TaxPayerListChallenge;
internal class TaxPayer
{
    public double SalaryIncome { get; set; }
    public double ServicesIncome { get; set; }
    public double CapitalIncome { get; set; }
    public double HealthSpending { get; set; }
    public double EducationSpending { get; set; }

    public TaxPayer(double salaryIncome, double servicesIncome, double capitalIncome, double healthSpending, double educationSpending)
    {
        SalaryIncome = salaryIncome;
        ServicesIncome = servicesIncome;
        CapitalIncome = capitalIncome;
        HealthSpending = healthSpending;
        EducationSpending = educationSpending;
    }
    public double SalaryTax()
    {
        double salaryIncomeMonth = (SalaryIncome / 12);
        if (salaryIncomeMonth >= 3000.00 && salaryIncomeMonth < 5000.00) 
        {
            return SalaryIncome * 0.10;
        }
        else if (salaryIncomeMonth >= 5000.00)
        {
            return SalaryIncome * 0.20;
        }
        else
        {
            return 0.0;
        }
    }
    public double ServicesTax()
    {
        return ServicesIncome * 0.15;
    }
    public double CapitalTax()
    {
        return CapitalIncome * 0.20;
    }
    public double GrossTax()
    {
        return SalaryTax() + ServicesTax() + CapitalTax();
    }
    public double TaxRebate()
    {
        double totalRebate = HealthSpending + EducationSpending;
        if (totalRebate <= (GrossTax() * 0.3)) 
        {
            return totalRebate;
        } 
        else 
        { 
            return GrossTax() * 0.3; 
        }
    }
    public double NetTax()
    {
        return GrossTax() - TaxRebate();
    }
}
