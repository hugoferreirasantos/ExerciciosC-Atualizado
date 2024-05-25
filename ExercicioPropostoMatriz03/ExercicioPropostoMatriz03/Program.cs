using System;

namespace ExercicioMatriz03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver
             empates.
             Entrada:
                A entrada contém o número N, depois os dados da matriz.
             Saída:
                A saída contém os números representando o maior elemento de cada linha da matriz.
             */

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

            //Ler a matriz e ver qual o maior valor valor para cada linha:
           
            for (int i  = 0; i < N; i++)
            {
                int maiorNumero = mat[i, 0];
                for (int j  = 0; j < N; j++)
                {
                    if (mat[i,j] > maiorNumero)
                    {
                        maiorNumero = mat[i, j];
                    }
                }

                Console.WriteLine(maiorNumero);
            }
            


        }


    }
}