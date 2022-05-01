// Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo
// números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz
using System;
namespace ExercicioMatriz
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            // Percorre as linhas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                // Percorre as colunas
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i, i]} ");
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Números negativos: {count}");
        }
    }
}
