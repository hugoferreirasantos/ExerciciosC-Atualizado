using System;

namespace Exercicio1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int carroX, carroY, km, sub;
            double tempo;

            carroX = 60;
            carroY = 90;

            sub = carroY - carroX;

            km = int.Parse(Console.ReadLine());

            tempo = (km * 60 / (sub));

            Console.WriteLine($"{tempo} minutos");
        }
    }
}