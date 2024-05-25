using System;
using System.Globalization;

namespace Exercicio1154EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 0, soma = 0, cont = 0, media;

            idade = double.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}