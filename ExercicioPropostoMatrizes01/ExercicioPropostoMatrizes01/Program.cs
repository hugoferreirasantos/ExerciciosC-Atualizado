using System;

namespace ExercicioMatriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
                na tela somente os números negativos da matriz.
                Entrada:
                    A entrada contém os números M e N na mesma linha, depois os dados da matriz.
                Saída:
                    A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.
             */


            int M, N;
            int[,] mat; //Declarando minha matriz;

            string[] s = Console.ReadLine().Split(" ");
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            mat = new int[M, N]; //Instânciando a matriz;

            Console.WriteLine();

            //Inserir valores dentro da minha matriz:
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("VALORES NEGATIVOS:");

            //Verificar os valores negativos:
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine($"{mat[i, j]}");
                    }
                }
            }









        }
    }
}