using System;

namespace SequentialStructure
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter four integer numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("The difference between the product of " +
                "A and B and the product of C and D is: " + ((a *b) - (c*d)));
        }
    }
}