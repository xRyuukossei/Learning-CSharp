using System;
using System.Globalization;

namespace InputData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("How many bedrooms are there in your house? ");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a product: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter your last name, age, height (all on the same line): ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}