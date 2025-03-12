using System;
using System.Globalization;
using System.Numerics;

namespace AthletesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many athletes? ");
            int athletes = int.Parse(Console.ReadLine());

            double totalWeight = 0.0;
            double highestAthlete = 0.0;
            string tallestAthlete = null;
            double womenTotalHeight = 0.0;
            int menAthletes = 0;
            int womenAthletes = 0;

            for (int i = 1; i <= athletes; i++)
            {
                Console.WriteLine($"Enter the data for athlete number {i}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Gender: ");
                char gender = char.Parse(Console.ReadLine());
                while (gender != 'F' && gender != 'M')
                {
                    Console.Write("Invalid value! Please enter F or M: ");
                    gender = char.Parse(Console.ReadLine());
                }

                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (height <= 0)
                {
                    Console.Write("Invalid value! Please enter a positive value: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (weight <= 0)
                {
                    Console.Write("Invalid value! Please enter a positive value: ");
                    weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Console.WriteLine("");

                totalWeight += weight;

                if (highestAthlete < height)
                {
                    highestAthlete += height;
                    tallestAthlete = name;
                }

                if (gender == 'M')
                {
                    menAthletes++;
                }

                if (gender == 'F')
                {
                    womenTotalHeight += height;
                    womenAthletes++;

                }
            }
            Console.WriteLine("REPORT:");
            Console.WriteLine("Average weight of athletes: " + (totalWeight/athletes).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tallest athlete: " + tallestAthlete);
            Console.WriteLine("Percentage of men: " + ((double)menAthletes/athletes*100).ToString("F1", CultureInfo.InvariantCulture) + "%");

            if (womenTotalHeight == 0)
            {
                Console.WriteLine("No women registered");
            }
            else
            {
                Console.WriteLine("Average height of women: " + (womenTotalHeight/womenAthletes).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}