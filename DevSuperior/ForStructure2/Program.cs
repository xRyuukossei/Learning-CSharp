using System;

namespace ForStructure2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            int inNumbers = 0, outNumbers = 0;

            Console.WriteLine($"Enter the next {n} numbers");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    inNumbers++;
                }
                else
                {
                    outNumbers++;
                }
            }
            Console.WriteLine($"{inNumbers} in\n{outNumbers} out");
        }
    }
}