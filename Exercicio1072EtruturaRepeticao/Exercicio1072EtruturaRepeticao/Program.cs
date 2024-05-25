using System;

namespace Exercicio1072EtruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,x, dentro = 0, fora = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if(x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");


        }
    }
}