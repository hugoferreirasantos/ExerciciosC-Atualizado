using System;
using System.Globalization;

namespace ExercicioResolvidoEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaPrimeiroSemestre, notaSegundoSemestre, notaFinal;

            notaPrimeiroSemestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaSegundoSemestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = notaPrimeiroSemestre + notaSegundoSemestre;

            if(notaFinal < 60)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F1",CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
        }
    }
}