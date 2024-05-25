using System;

namespace Exercicio1132EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, max, min, somaValor = 0;

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


            for (int i = min; i <= max; i++)
            {
                if(i % 13 != 0)
                {
                    somaValor = somaValor + i;
                }
            }

            Console.WriteLine(somaValor);
        }
    }
}