using System;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;
            N = int.Parse(Console.ReadLine());

            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            foreach(int i in vet)
            {
                if(i < 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}