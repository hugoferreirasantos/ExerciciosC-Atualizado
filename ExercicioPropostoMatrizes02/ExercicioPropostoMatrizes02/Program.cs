using System;

namespace ExercicioMatriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2) Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos
             elementos de cada linha da matriz.
             Entrada:
                A entrada contém o número N, depois os dados da matriz.
             Saída:
                A saída contém os números representando a soma dos elementos de cada linha da matriz.
             */

            int N;
            int[,] mat;
            string[] s;
            int soma;

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
            //Ler a matriz e ralizar a soma das linhas:
            for (int i = 0; i < N; i++)
            {
                soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine($"{soma}");
            }


        }


    }
}