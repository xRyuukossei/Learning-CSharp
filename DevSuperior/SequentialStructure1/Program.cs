using System;

namespace SequentialStructure1
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two numbers to be added: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("SUM = " + (a + b));
        }
    }
}