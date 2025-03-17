using System;
using System.Globalization;

namespace ClassExercise3
{
	class Program
	{
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Student Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the three grades of the student: ");
            student.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("FINAL GRADE: " + student.FinalGrade());

            if (student.Approved() == true)
            {
                Console.WriteLine("APPROVED");
            }
            else 
            {
                Console.WriteLine("FAILED");
                Console.WriteLine(student.MissingPoints().ToString("F2", CultureInfo.InvariantCulture) + " POINTS WERE MISSING");
            }
        }
    }
}