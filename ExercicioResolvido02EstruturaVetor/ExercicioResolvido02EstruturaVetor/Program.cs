using System;
using System.Globalization;

namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma = 0;
            double[] vet;

            N = int.Parse(Console.ReadLine());

            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            foreach (int i in vet)
            {
                Console.Write(i.ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }

            double media = soma / N;

            Console.WriteLine($"Soma: {soma.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Media: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}