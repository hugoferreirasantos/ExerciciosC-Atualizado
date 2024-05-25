using System;

namespace Exercicio1099EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                    }
                }
                Console.WriteLine(soma);

            }
        }
    }
}