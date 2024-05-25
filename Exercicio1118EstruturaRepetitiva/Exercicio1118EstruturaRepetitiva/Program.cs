using System;
using System.Globalization;

namespace Exercicio1118EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma = 0, mediaSemestral = 0;
            int x = 0, cont = 0;
            bool flag = true;

            while (flag)
            {
                cont = 0;
                soma = 0;

                while (cont < 2)
                {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        soma = soma + nota;
                        cont = cont + 1;
                    }
                }

                mediaSemestral = soma / cont;
                Console.WriteLine($"media = {mediaSemestral.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());

                while (x != 1 && x != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                }

                if (x != 1)
                {
                    flag = false;
                }
            }
        }
    }
}