using System;
using System.Globalization;


namespace ExercicioResolvidoEstruturaRepetivaEnquanto02
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma = 0, media;
            int cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if ( cont == 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

            

        }
    }
}