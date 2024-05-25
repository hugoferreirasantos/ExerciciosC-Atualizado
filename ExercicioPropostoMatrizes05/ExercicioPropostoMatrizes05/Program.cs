using System;

namespace ExercicioProposto05
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] matA;
            int[,] matB;
            int[,] matC;

            string[] s = Console.ReadLine().Split(" ");
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            matA = new int[M, N];
            matB = new int[M, N];
            matC = new int[M, N];

            Console.WriteLine();
            //Inserir valores na matriz A:
            for(int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(" ");

                for(int j = 0; j < N; j++)
                {
                    matA[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();
            //Inserir valores na matriz B:
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    matB[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matC[i, j] = matA[i, j] + matB[i, j];
                    Console.Write(matC[i, j] + " "); // Imprime o elemento atual da matriz C
                }
                Console.WriteLine(); // Muda para a próxima linha após imprimir todos os elementos de uma linha
            }


        }
    }
}