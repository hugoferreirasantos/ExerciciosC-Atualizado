using System;

namespace Exercicio1044EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;

            string[] vet = Console.ReadLine().Split(' ');

            valor1 = int.Parse(vet[0]);
            valor2 = int.Parse(vet[1]);

            if( valor1 % valor2 == 0 || valor2 % valor1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}