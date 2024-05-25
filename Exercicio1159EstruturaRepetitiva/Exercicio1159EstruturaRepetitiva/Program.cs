using System;

namespace Exercicio1159EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma, cont;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x = x + 1;
                }

                soma = 0;
                cont = 0;

                while (cont < 5)
                {
                    soma = soma + x;
                    x = x + 2;
                    cont = cont + 1;
                }

                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());

            }
        }
    }
}