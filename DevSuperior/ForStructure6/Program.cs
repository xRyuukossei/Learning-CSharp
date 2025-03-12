using System;

namespace ForStructure6
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}