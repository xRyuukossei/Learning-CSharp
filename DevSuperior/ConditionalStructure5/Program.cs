using System;
using System.Globalization;

namespace ConditionalStructure5
{
	class Program
	{
        static void Main(string[] args)
        {
            double id1 = 4.00;
            double id2 = 4.50;
            double id3 = 5.00;
            double id4 = 2.00;
            double id5 = 1.50;

            Console.WriteLine("Enter the product code and the quantity: ");
            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            if (n1 == 1)
            {
                Console.WriteLine("Total: R$ " + (n2 * id1).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n1 == 2)
            {
                Console.WriteLine("Total: R$ " + (n2 * id2).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n1 == 3)
            {
                Console.WriteLine("Total: R$ " + (n2 * id3).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n1 == 4)
            {
                Console.WriteLine("Total: R$ " + (n2 * id4).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n1 == 5)
            {
                Console.WriteLine("Total: R$ " + (n2 * id5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("You entered a non-existent code!");
            }
        }
    }
}