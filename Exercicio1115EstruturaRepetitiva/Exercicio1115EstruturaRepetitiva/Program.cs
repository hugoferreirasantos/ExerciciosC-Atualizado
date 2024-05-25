using System;

namespace Exercicio1115EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, condicional = 1;


            while (condicional != 0)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    condicional = 0;
                }
                
            }
        }
    }
}