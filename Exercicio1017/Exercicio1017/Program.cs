using System;
using System.Globalization;

namespace Exercicio1017
{
    class Program
    { 
        static void Main(string[] args)
        {
            int velocidadeMedia = int.Parse(Console.ReadLine());
            int tempoGasto = int.Parse(Console.ReadLine());

            double distanciaPercorrida = velocidadeMedia * tempoGasto;
            double litrosNecessarios = distanciaPercorrida / 12;

            Console.WriteLine($"{litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }

}
