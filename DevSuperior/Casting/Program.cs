using System;

    namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1.2f;

            Console.WriteLine("Example with Floating Number: " + a);

            double b = a;

            Console.WriteLine("Implicit Conversion: " + b);

            int c = (int)b;

            Console.WriteLine("Explicit Conversion:  " + c);
        }
    }
}
