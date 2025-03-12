using System;
using System.Globalization;

namespace ForStructure4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine("Impossible division");
                }
                else
                {
                    double d = n1 / n2;
                    Console.WriteLine(d.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}