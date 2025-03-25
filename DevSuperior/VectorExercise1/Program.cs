using System;

namespace VectorExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Guesthouse[] guesthouses = new Guesthouse[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nRent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                guesthouses[room] = new Guesthouse(name, email, room);
            }

            Console.WriteLine("\nBusy rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (guesthouses[i] != null)
                {
                    Console.WriteLine(guesthouses[i]);
                }
            }
        }
    }
}