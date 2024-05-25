using System;

namespace Exercicio1133EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            for (int i = min + 1; i < max; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}