using System;
using System.Globalization;
using System.Collections.Generic;

namespace TaxPayerListChallenge
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("How many taxpayers will you enter? ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("\nEnter the data for the " + n +"° taxpayer:");
                Console.Write("Annual income from salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Annual income from service provision: ");
                double serviceProvision = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Annual income from capital gains: ");
                double capitalGains = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Medical expenses: ");
                double medicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Educational expenses: ");
                double educationalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add( new TaxPayer(salary, serviceProvision, capitalGains, medicalExpenses, educationalExpenses));
            }

            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine("\nSummary of the " + n + "° taxpayer:");
                Console.WriteLine("Total gross tax: " + taxPayer.GrossTax().ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Deduction: " + taxPayer.TaxRebate().ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Tax due: " + taxPayer.NetTax().ToString("F2"), CultureInfo.InvariantCulture);

            }
        }
    }
}