using System;
using System.Globalization;

namespace SintaxeOperadoreAtribuicaoCumulatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe Opcional Operadores Atribuicao Cumulatica

            /*
             
             */

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100)
            {
                //conta = conta + (minutos - 100) * 2.0;
                conta += (minutos - 100) * 2.0;
                /*Outros exemplos de Atrubuição cumulativa:
                 * 
                 * a += b     |  a = a + b
                 * a -= b     |  a = a - b
                 * a *= b     |  a = a * b
                 * a /= b     |  a = a / b
                 * a %= b     |  a = a % b
                 * 
                 * 
                */

            }

            Console.WriteLine($"Valor a pagar: R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}