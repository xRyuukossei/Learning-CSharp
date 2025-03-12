using System;
using System.Data;
using System.Globalization;

namespace TaxChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Annual income with salary: ");
            double aIncomeSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxIncomeSalary = 0;
            Console.Write("Annual income with service provision: ");
            double aIncomeServiceProvision = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxIncomeServiceProvision = aIncomeServiceProvision * 0.15;
            Console.Write("Annual income with capital gains: ");
            double aIncomeGapitalGains = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxIncomeGapitalGains = aIncomeGapitalGains * 0.20;
            Console.Write("Medical expenses: ");
            double medicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Educational expenses: ");
            double educationalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nINCOME TAX REPORT\n\nINCOME SUMMARY:");

            if (aIncomeSalary < 36000.0)
            {
                Console.WriteLine("\nTax on salary: Exempt");
            } else if (aIncomeSalary >= 36000.0 && aIncomeSalary < 60000.0)
            {
                taxIncomeSalary = aIncomeSalary * 0.10;
                Console.WriteLine($"Tax on salary: " + taxIncomeSalary.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                taxIncomeSalary = aIncomeSalary * 0.20;
                Console.WriteLine("Tax on salary: " + taxIncomeSalary.ToString("F2", CultureInfo.InvariantCulture));
            }
            double totalTax = taxIncomeSalary + taxIncomeServiceProvision + taxIncomeGapitalGains;
            double maxReduction = totalTax * 0.30;

            Console.WriteLine($"Tax on service: "+ taxIncomeServiceProvision.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Tax on capital gains: " + taxIncomeGapitalGains.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\nDEDUCTIONS: ");
            Console.WriteLine("Maximum deductible: " + maxReduction.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Deductible expenses: " + (medicalExpenses + educationalExpenses).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\nSUMMARY: ");
            Console.WriteLine("Total gross tax: " + totalTax.ToString("F2", CultureInfo.InvariantCulture));

            double totalExpenses = medicalExpenses + educationalExpenses;

            if (maxReduction > totalExpenses)
            {
                maxReduction = totalExpenses;
                Console.WriteLine("Tax reduction: " + maxReduction.ToString("F2", CultureInfo.InvariantCulture));
            }
            else 
            {
                Console.WriteLine("Tax reduction: " + maxReduction.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Tax due: " + (totalTax - maxReduction).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}