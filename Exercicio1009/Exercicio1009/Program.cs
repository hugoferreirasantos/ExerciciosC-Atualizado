using System;
using System.Globalization;

namespace Exercicio1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, valorVendasEfetuadas, total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorVendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salarioFixo + (valorVendasEfetuadas * 0.15);

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}