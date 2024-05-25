using System;
using System.Globalization;

namespace Exercicio1116EstruturaRepetiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y;
            double resultadoDiv;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if(y != 0)
                {
                    resultadoDiv = (double) x / (double) y;
                    Console.WriteLine(resultadoDiv.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }

                
            }
        }
    }
}