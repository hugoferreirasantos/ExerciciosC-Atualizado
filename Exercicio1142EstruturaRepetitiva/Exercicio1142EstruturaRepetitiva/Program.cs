using System;

namespace Exercicio1142EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, interador, soma;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{4 * (i - 1) + 1} {4 * (i - 1) + 2} {4 * (i - 1) + 3} PUM");
            }
        }
    }
}