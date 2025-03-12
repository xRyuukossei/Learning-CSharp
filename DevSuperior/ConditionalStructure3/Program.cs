using System;

namespace ConditionalStructure3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer numbers: ");

            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("They are multiples");
            }
            else
            {
                Console.WriteLine("They are not multiples");
            }
        }
    }
}