using System;
using System.Globalization;

namespace Exercicio1079EstruturaRepetiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double nota1 = double.Parse(vet[0]);
                double nota2 = double.Parse(vet[1]);
                double nota3 = double.Parse(vet[2]);

                double media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10 ;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
