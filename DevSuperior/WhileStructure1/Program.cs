using System;

namespace WhileStructure1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password: ");

            int pwd = int.Parse(Console.ReadLine());

            while (pwd != 2002)
            {
                Console.WriteLine("Invalid password");
                pwd = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Access granted");
        }
    }
}