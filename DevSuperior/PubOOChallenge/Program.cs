using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PubOOChallenge
{
	class Program
	{
        static void Main(string[] args)
        {
            Bill bill = new Bill();

            Console.Write("Gender: ");
            bill.Gender = char.Parse(Console.ReadLine());
            Console.Write("Number of Beers: ");
            bill.Beer = int.Parse(Console.ReadLine());
            Console.Write("Number of Soft Drinks: ");
            bill.SoftDrink = int.Parse(Console.ReadLine());
            Console.Write("Number of Barbecues: ");
            bill.Barbecue = int.Parse(Console.ReadLine());

            Console.WriteLine("\nREPORTS: ");
            Console.WriteLine("Consumption = R$ " + bill.Feeding().ToString("F2"), CultureInfo.InvariantCulture);
            if (bill.Cover() == 0.0)
            {
                Console.WriteLine("Exempt from cover charge");
            }
            else
            {
                Console.WriteLine("Cover Charge = R$ " + bill.Cover().ToString("F2"), CultureInfo.InvariantCulture);
            }
                       
            Console.WriteLine("Ticket = R$ " + bill.Ticket().ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine("\nAmount to pay = R$ " + bill.Total().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}