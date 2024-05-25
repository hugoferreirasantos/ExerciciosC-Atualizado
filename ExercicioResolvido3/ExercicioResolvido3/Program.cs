using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double mediaIdades;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);


            mediaIdades = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine($"A idade média {nome1} e {nome2} é de {mediaIdades.ToString("F1", CultureInfo.InvariantCulture)} anos");
        }
    }
}