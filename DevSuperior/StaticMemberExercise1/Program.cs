using System;
using System.Globalization;

namespace StaticMemberExercise1
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("What is the exchange rate of the dollar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many dollars are you going to buy? ");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Amount to be paid in reais = " + CurrencyConverter.DolToBrl(dolar, real).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}