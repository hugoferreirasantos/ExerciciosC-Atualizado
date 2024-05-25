using System;

namespace Exercicio1074EstruturaRepetiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    if (x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else if (x == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else if (x < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}