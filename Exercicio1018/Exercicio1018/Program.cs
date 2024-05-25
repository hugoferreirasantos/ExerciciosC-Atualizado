using System;

namespace Exercicio1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0, notas2 = 0, notas1 = 0;

            N = int.Parse(Console.ReadLine());

            while (N >= 100)
            {
                notas100 += 1;
                N -= 100;
            }

            while (N >= 50)
            {
                notas50 += 1;
                N -= 50;
            }

            while (N >= 20)
            {
                notas20 += 1;
                N -= 20;
            }

            while (N >= 10)
            {
                notas10 += 1;
                N -= 10;
            }

            while (N >= 5)
            {
                notas5 += 1;
                N -= 5;
            }

            while (N >= 2)
            {
                notas2 += 1;
                N -= 2;
            }

            notas1 = N;

            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1} nota(s) de R$ 1,00");



        }
    }
}