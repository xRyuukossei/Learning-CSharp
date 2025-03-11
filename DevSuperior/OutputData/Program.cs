using System;
using System.Globalization;
using System.Text;

namespace OutputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Desktop";
            string product2 = "Office Desk";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double average = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine("{0}, priced at: $ {1}", product1, price1);
            Console.WriteLine($"{product2}, priced at: $ {price2}");
            Console.WriteLine();
            Console.WriteLine("Registration: " + age + " years old, code " + code + " and gender: " + gender);
            Console.WriteLine();
            Console.WriteLine("Measure with eight decimal places: {0:F8}", average);
            Console.WriteLine($"Rounded (Three decimal places): {average:F3}");
            Console.WriteLine("Invariant culture decimal separator: " + average.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}