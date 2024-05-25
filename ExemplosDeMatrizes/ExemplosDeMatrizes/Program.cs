using System;

namespace ExemplosDeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A; //Declarando uma matriz:

            string[] s1 = Console.ReadLine().Split(" ");
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);

            //Instânciação da Matriz:
            A = new int[M, N];


            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}