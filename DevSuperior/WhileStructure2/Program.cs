using System;

namespace WhileStructure2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the X and Y coordinates: ");
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Q4");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}

