using System;

namespace WhileStructure3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("Enter the type of fuel refueled: ");
            int x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool++;
                }
                else if (x == 2)
                {
                    gasolina++;
                }
                else if (x == 3)
                {
                    diesel++;
                }
                else 
                {
                    Console.WriteLine("Invalid code, please enter it again");
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}