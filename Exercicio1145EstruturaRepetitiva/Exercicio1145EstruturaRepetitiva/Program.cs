using System;

namespace Exercicio1145EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                
                if(i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }
    }
}