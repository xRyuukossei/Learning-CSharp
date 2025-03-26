using System;

namespace MatrixExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] vet2 = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(vet2[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine("Position: " + i + "," + j + ":");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + matrix.GetValue(i, j - 1));
                        }
                        if (j + 1 < n)
                        {
                            Console.WriteLine("Rigth: " + matrix.GetValue(i, j + 1));
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + matrix.GetValue(i - 1, j));
                        }
                        if (i + 1 < m)
                        {
                            Console.WriteLine("Down: " + matrix.GetValue(i + 1, j));
                        }
                    }
                }
            }
        }
    }
}