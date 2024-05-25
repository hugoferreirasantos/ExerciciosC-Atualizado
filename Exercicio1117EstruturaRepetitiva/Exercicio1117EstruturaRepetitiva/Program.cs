using System;
using System.Globalization;

namespace Exercicio1117EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0, soma = 0, mediaSemestral = 0, cont = 0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma = soma + nota;
                    cont = cont + 1;
                }
            }

            mediaSemestral = soma / cont;
            Console.WriteLine($"media = {mediaSemestral.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}