using System;
using System.Globalization;

namespace Exercicio1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia, subX, subY;

            string[] vet1 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            subX = (x2 - x1);
            subY = (y2 - y1);


            distancia = Math.Sqrt(Math.Pow(subX,2.0) + Math.Pow(subY, 2.0));

            Console.WriteLine($"{distancia.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}