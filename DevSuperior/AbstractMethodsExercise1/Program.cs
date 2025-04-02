using AbstractMethodsExercise1.Entities;
using System.Globalization;

namespace AbstractMethodsExercise1
{
	class Program
	{
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
            }
            Console.WriteLine("\nTAXES PAID:");
            double totalTax = 0.0;
            foreach (TaxPayer t in taxPayers)
            {
                Console.WriteLine(t.Name + ": $ " + t.Tax().ToString("F2"), CultureInfo.InvariantCulture);
                totalTax += t.Tax();
            }
            Console.WriteLine("\nTOTAL TAXES: $ " + totalTax.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}