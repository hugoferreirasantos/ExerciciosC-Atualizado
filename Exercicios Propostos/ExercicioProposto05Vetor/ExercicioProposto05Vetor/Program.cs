using System;
using System.Globalization;

namespace ExercicioProposto05Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o vetor com o tamanho:
            int[] numeros = new int[N];

            //Inserir os valores dentro do vetor:
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            //Media Aritimetica somente dos números pares lidos:
            int cont = 0;
            int soma = 0;

            foreach (int numero in numeros)
            {
                if(numero % 2 == 0)
                {
                    soma = soma + numero;
                    cont++;
                }
            }

            double media = (double) soma / cont;

            Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}