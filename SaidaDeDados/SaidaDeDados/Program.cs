using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             //Exemplo: Saída de Dados

            Console.Write("Olá mundo");
            Console.Write("Bom dia");
             */

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';


            Console.Write(x + "\n");
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("RESULTADO " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();

            Console.WriteLine($"A paciente {z} tem {y} anos, e o seu sexo é: {w}");



            Console.ReadLine();

            




        }
    }
}