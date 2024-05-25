using System;
using System.Globalization;

namespace Exercicio1036EstuturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            //Variáveis para inserção de valor:
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Calculo do Delta:
            delta = Math.Pow(b, 2.0) - 4 * a * c;

            //Verificando se a equação é impossível de ser calculada:
            if(a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                //Imprimindo o resultado de R1 e R2:
                Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");

            }





        }
    }
}