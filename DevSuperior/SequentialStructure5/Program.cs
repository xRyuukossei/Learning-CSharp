using System;
using System.Globalization;

namespace SequentialStructure5
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the code, quantity, and unit price of product 1: ");
            string[] vet1 = Console.ReadLine().Split(' ');

            int code1 = int.Parse(vet1[0]);
            int quantity1= int.Parse(vet1[1]);
            double price1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the code, quantity, and unit price of product 2: ");
            string[] vet2 = Console.ReadLine().Split(' ');

            int code2 = int.Parse(vet2[0]);
            int quantity2 = int.Parse(vet2[1]);
            double price2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Amount to pay: R$ " + ((quantity1 * price1) + (quantity2 * price2))
                .ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}