using System;

namespace Exercicio1101EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            string[] vet = Console.ReadLine().Split(' ');

            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                int menor = m;
                int maior = n;

                if (m > n)
                {
                    menor = n;
                    maior = m;
                }

                int soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);

                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);

            }
        }
    }
}
