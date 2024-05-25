using System;
using System.Globalization;

namespace Exercicio1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi = 3.14159, areaTriangulo,areaCirculo, areaTrapezio,areaQuadrado,areaRetangulo;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = (A * C) / 2.0;
            areaCirculo = pi * Math.Pow(C, 2.0);
            areaTrapezio = (A + B) * C / 2.0;
            areaQuadrado = (B * B);
            areaRetangulo = (A * B);

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}