using System;
using System.Globalization;

namespace Exercicio1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, formula;

            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            formula = (4 / 3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine($"VOLUME = {formula.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}