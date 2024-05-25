using System;

namespace EstruturaRepetitivaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aprendendo a utilizar a estrutura para:
            //int N, x, soma;

            /*
             * **EXEMPLO 01:**
               N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);

            //Contagem normal:
            Console.WriteLine("Contagem Normal:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Valor de i: {i}");
            }

            Console.WriteLine();

            Console.WriteLine("Contagem Regressiva:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine($"Valor de i: {i}");
            }
             */
            int x, y;

            x = 8;
            y = 3;
            for (int i = 0; y < x; i++)
            {
                x = x - 2;
                y = y + 1;
                Console.WriteLine(i);
            }




        }
    }
}