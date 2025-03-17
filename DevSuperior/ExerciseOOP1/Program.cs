using System;

namespace ExerciseOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("First person's data: ");

            Console.Write("Name: ");
            e1.name = Console.ReadLine();
            Console.Write("Age: ");
            e1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Second person's data: ");

            Console.Write("Name: ");
            e2.name = Console.ReadLine();
            Console.Write("Age: ");
            e2.age = int.Parse(Console.ReadLine());

            if (e2.age > e1.age)
            {
                Console.WriteLine("Oldest person: " + e2.name);
            }
            else 
            {
                Console.WriteLine("Oldest person: " + e1.name);
            }
        }
    }
}