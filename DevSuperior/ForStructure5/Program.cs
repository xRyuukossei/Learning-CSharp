using System;

namespace ForStructure5
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");

            int f = 1, n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }
    }
}