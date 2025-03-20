using System;
using System.Globalization;

namespace ConstructorEncapsulationExercise
{
	class Program
	{
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder: ");
            string name = Console.ReadLine();
            Console.Write("Will there be an initial deposit (y/n)? ");
            char initialDeposit = char.Parse(Console.ReadLine());

            if (initialDeposit == 'y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Account(name, number, balance);
            }
            else
            {
                account = new Account(name, number);
            }

            Console.WriteLine("\nAccount details: ");
            Console.WriteLine(account);

            Console.Write("\nEnter a deposit amount: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Updated account details: ");
            Console.WriteLine(account);

            Console.Write("\nEnter a withdrawal amount: ");
            account.Withdrawal(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Updated account details: ");
            Console.WriteLine(account);
        }
    }
}