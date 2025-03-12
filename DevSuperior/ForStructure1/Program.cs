using System;

namespace ForStructure1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 1000");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 1000)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please, enter a valid number");
            }
        }
    }
}