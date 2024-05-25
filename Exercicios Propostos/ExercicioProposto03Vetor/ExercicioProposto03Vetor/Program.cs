using System;

namespace ExercicioProposto03Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o tamnho do vetores:
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            //Inserção de valores dentro dos vetores A e B e C;
            string[] s = Console.ReadLine().Split(' ');
            string[] w = Console.ReadLine().Split(' ');


            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
                B[i] = int.Parse(w[i]);
            }

            for (int i =0; i < N; i++)
            {
                C[i] = A[i] + B[i]; 
            }

            //Ler o vetor C;
            Console.WriteLine();
            foreach (var x in C)
            {
                Console.Write($"{x} ");
            }



        }
    }
}