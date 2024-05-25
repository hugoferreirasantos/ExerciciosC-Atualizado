using System;
using System.Globalization;

namespace ExercicioProposto06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, linha, coluna;
            double[,] mat;
            string[] s;

            N = int.Parse(Console.ReadLine());
            mat = new double[N, N];

            Console.WriteLine();

            //Inserindo os dados dentro da matriz:
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            Console.WriteLine();

            linha = int.Parse(Console.ReadLine());
            coluna = int.Parse(Console.ReadLine());

            //Ler a matriz para somar numeros positivos:
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] >= 0)
                    {
                        soma = soma + mat[i, j];
                    }
                }
            }

            Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

            //Ler os valores de uma linha:
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[linha, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Ler os valores de uma coluna:
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Ler a dagonal principal:
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Ler a matriz e elevar ao quadrado os números negativos:
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        mat[i, j] = (double)Math.Pow(mat[i, j], 2);
                    }
                }
            }


            //Imprimir a matriz alterada:
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }







        }
    }
}