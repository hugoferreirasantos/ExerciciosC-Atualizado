using System;

namespace Exercicio1153EstruturaRepetiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, fatorial,resultado = 1 ;

            N = int.Parse(Console.ReadLine());

            for (fatorial = 1; fatorial <= N; fatorial++)
            {
                resultado = resultado * fatorial;
            }

            Console.WriteLine(resultado);
        }
    }
}