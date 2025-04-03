using EducationPlatformChallenge.Entities;
using System;

namespace EducationPlatformChallenge
{
	class Program
	{
        static void Main(string[] args)
        {
            List<Lesson> lessons = new List<Lesson>();

            Console.Write("How many lessons are in the course? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Data of the {i} lesson: ");
                Console.Write("Content or task (c/t)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Title: ");
                string title = Console.ReadLine();
                if (ch == 'c')
                {
                    Console.Write("Video URL: ");
                    string url = Console.ReadLine();
                    Console.Write("Duration in seconds: ");
                    int duration = int.Parse(Console.ReadLine());
                    lessons.Add(new Video(title, url, duration));
                }
                else 
                {
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Number of questions: ");
                    int numberOfQuestions = int.Parse(Console.ReadLine());
                    lessons.Add(new Tasks(title, description, numberOfQuestions));
                }
            }
            int totalTime = 0;
            foreach (Lesson lesson in lessons)
            { 
                totalTime += lesson.Duration();
            }
            Console.WriteLine("\nTOTAL COUSER DURATION = " + totalTime + " seconds");
        }
    }
}