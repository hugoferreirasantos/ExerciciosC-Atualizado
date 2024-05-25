using System;
using System.Runtime.Serialization;

namespace ExercicioResolvidoVetor01
{
    class Program
    {

        static void Main(string[] args)
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());

            //Instânciação do Vetor:
            vet = new int[N];


            //Inserção de valores dentro do Vetor:
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }

            }




        }
    }
}