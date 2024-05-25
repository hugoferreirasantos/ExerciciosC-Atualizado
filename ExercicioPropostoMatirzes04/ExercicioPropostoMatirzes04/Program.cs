using System;

namespace ExercicioProposto04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;
            string[] s;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            Console.WriteLine();

            //Inserir valores dentro da matriz:
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine();

            //Ler a matriz e realizar a soma dos números acima da diagonal principal:
            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++) // Começa de i + 1 para pegar os elementos acima da diagonal principal
                {
                    soma += mat[i, j];
                }
            }

            Console.WriteLine(soma); // Imprime a soma dos elementos acima da diagonal principal
        }
    }
}
