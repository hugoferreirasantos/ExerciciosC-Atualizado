using System;
using System.Globalization;

namespace Exercicio1094EstruturaRepetiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quantia, totalC = 0, totalR = 0, totalS = 0, total = 0, somaC = 0, somaR = 0, somaS = 0;
            double porcentagemTotal, porcentagemC, porcentagemR, porcentagemS;
            char cobaia;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                quantia = int.Parse(vet[0]);
                cobaia = char.Parse(vet[1]);

                if (cobaia == 'C')
                {
                    totalC = totalC + 1;
                    somaC = somaC + quantia;

                }
                else if (cobaia == 'R')
                {
                    totalR = totalR + 1;
                    somaR = somaR + quantia;
                }
                else if (cobaia == 'S')
                {
                    totalS = totalS + 1;
                    somaS = somaS + quantia;
                }

                total = total + quantia;


            }

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {somaC}");
            Console.WriteLine($"Total de ratos: {somaR}");
            Console.WriteLine($"Total de sapos: {somaS}");

            porcentagemTotal = total / 100.0;

            porcentagemC = somaC / porcentagemTotal;
            porcentagemR = somaR / porcentagemTotal;
            porcentagemS = somaS / porcentagemTotal;

            Console.WriteLine($"Percentual de coelhos: {porcentagemC.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemR.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemS.ToString("F2", CultureInfo.InvariantCulture)} %");



        }
    }
}