using System;

namespace Exercicio1134EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoConbustivel = 0, contTipo1 = 0, contTipo2 = 0, contTipo3 = 0;


            while (tipoConbustivel != 4)
            {
                tipoConbustivel = int.Parse(Console.ReadLine());

                switch (tipoConbustivel)
                {
                    case 1:
                        contTipo1 = contTipo1 + 1;
                        break;

                    case 2:
                        contTipo2 = contTipo2 + 1;
                        break;

                    case 3:
                        contTipo3 = contTipo3 + 1;
                        break;

                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contTipo1}");
            Console.WriteLine($"Gasolina: {contTipo2}");
            Console.WriteLine($"Diesel: {contTipo3}");


        }
    }
}