using System;

namespace ForStructure7
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}