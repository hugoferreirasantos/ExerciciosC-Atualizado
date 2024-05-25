using System;
using System.Globalization;

namespace Exercicio1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, mediaPonderada, PesoNota1, PesoNota2, somaPeso;

            PesoNota1 = 3.5;
            PesoNota2 = 7.5;
            somaPeso = PesoNota1 + PesoNota2;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = ((nota1 * PesoNota1) + (nota2 * PesoNota2)) / somaPeso;

            Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F5",CultureInfo.InvariantCulture)}");

        }
    }
}