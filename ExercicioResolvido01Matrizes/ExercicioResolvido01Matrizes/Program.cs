using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A; //Declaração da Matriz;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N]; //Instanciação da Matriz;

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }

            Console.WriteLine();

            

            int cont = 0;
            for( int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine($"QUANTIDADE DE NEGATIVOS: {cont}");



        }
    }
}