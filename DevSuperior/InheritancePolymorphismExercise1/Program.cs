using InheritancePolymorphismExercise1.Entitites;
using System.Globalization;

namespace InheritancePolymorphismExercise1
{
	class Program
	{
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u') 
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}