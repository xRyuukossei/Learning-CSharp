using System;

namespace ConditionalStructure2
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Write("Please, enter an integer number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}