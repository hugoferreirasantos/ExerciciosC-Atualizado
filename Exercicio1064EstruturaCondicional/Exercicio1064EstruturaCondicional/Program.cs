using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] vet = { a, b, c, d, e, f };

            int cont = 0;
            double soma = 0;
            double media;


            foreach (double i in vet)
            {
                if (i > 0.0)
                {
                    cont++;
                    soma += i;
                }
            }

            media = soma / cont;

            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");


        }
    }
}