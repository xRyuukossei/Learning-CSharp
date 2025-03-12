using System;

namespace ConditionalStructure1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter an integer number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("NEGATIVE");
            }
            else
            {
                Console.WriteLine("NOT NEGATIVE");
            }
        }
    }
}