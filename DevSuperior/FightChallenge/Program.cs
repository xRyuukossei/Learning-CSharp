using System;

namespace FightChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first champion's data: ");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Health: ");
            int health1 = int.Parse(Console.ReadLine());
            Console.Write("Attack: ");
            int attack1 = int.Parse(Console.ReadLine());
            Console.Write("Armor: ");
            int armor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the second champion's data: ");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Health: ");
            int health2 = int.Parse(Console.ReadLine());
            Console.Write("Attack: ");
            int attack2 = int.Parse(Console.ReadLine());
            Console.Write("Armor: ");
            int armor2 = int.Parse(Console.ReadLine());

            Champion champion1 = new Champion(name1, attack1, armor1, health1);
            Champion champion2 = new Champion(name2, attack2, armor2, health2);

            Console.Write("\nHow many turns do you want to execute? ");
            int rounds = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rounds; i++)
            {
                if (champion1.Life > 0 && champion2.Life > 0)
                {
                    champion1.TakeDamage(attack2);
                    champion2.TakeDamage(attack1);
                    Console.WriteLine($"\nTurn {i} result: ");
                    Console.WriteLine(champion1.Status());
                    Console.WriteLine(champion2.Status());
                }
            }
            Console.WriteLine("\nEND OF COMBAT");
        }
    }
}