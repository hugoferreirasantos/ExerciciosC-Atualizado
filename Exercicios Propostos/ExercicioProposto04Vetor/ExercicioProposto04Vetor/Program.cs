using System;
using System.Globalization;

namespace ExercicioProposto04Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o tamanho do vetor:
            double[] numeros = new double[N];

            //Inserir valores dentro do vetor:
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            //Realizar a media aritmetica e verificar que ficou abaixo dessa media:
            double soma = 0.0;
            foreach (double numero in numeros)
            {
                soma = soma + numero;
            }
            double media = soma / N;

            Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");

            foreach (double numero in numeros)
            {
                if(numero < media)
                {
                    Console.WriteLine($"{numero.ToString("F1",CultureInfo.InvariantCulture)}");
                }
            }


        }
    }
}