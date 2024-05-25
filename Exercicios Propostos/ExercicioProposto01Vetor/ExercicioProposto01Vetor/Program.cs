using System;
using System.Globalization;

namespace ExercicioProposto01Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Informar o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o vetor:
            double[] numeros = new double[N];

            //Inserção de valores dentro do vetor:
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            //Ler o vetor e verificar qual número é maior:
            double max = numeros[0];
            for (int i = 1; i < N; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }

            Console.WriteLine(max.ToString("F1", CultureInfo.InvariantCulture));
            
            Console.WriteLine(Array.IndexOf(numeros, max));
        }
    }
}