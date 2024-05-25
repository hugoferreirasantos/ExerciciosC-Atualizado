using System;
using System.Globalization;

namespace Exercicio1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, pesoNota1, pesoNota2, pesoNota3, mediaPonderada, somaPesos;

            pesoNota1 = 2.0;
            pesoNota2 = 3.0;
            pesoNota3 = 5.0;
            somaPesos = pesoNota1 + pesoNota2 + pesoNota3;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = ((nota1 * pesoNota1) + (nota2 * pesoNota2) + (nota3 * pesoNota3)) / somaPesos;

            Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
