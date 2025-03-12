using System;

namespace ConditionalStructure4
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start time and the end time of the game: ");

            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            if (n1 < n2)
            {
                int total = n2 - n1;
                Console.WriteLine($"The game lasted {total} hours");
            }
            else if (n1 > n2)
            {
                int total = 24 - n1 + n2;
                Console.WriteLine($"The game lasted {total} hours");
            }
            else 
            {
                int total = 24;
                Console.WriteLine($"The game lasted {total} hours");
            }
        }
    }
}