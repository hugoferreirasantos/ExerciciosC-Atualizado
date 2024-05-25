using System;

namespace Exercicio1144EstruturaRepetiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2.0)} {Math.Pow(i, 3.0)}");
                Console.WriteLine($"{i} {Math.Pow(i, 2.0) + 1} {Math.Pow(i, 3.0) + 1}");
            }
        }
    }
}