using System;
using System.Globalization;

namespace ClassExercise1
{
	class Program
	{
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the width and height of the rectangle: ");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(rectangle);
        }
    }
}