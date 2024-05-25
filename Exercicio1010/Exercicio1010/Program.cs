using System;
using System.Globalization;

namespace Exercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPecas1, codPeca2, numPecas2;
            double valorUnitariPeca1, valorUnitariPeca2, soma, mult1, mult2 ;

            string[] vet = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(vet[0]);
            numPecas1 = int.Parse(vet[1]);
            valorUnitariPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            mult1 = numPecas1 * valorUnitariPeca1;

            string[] vet2 = Console.ReadLine().Split(' ');

            codPeca2 = int.Parse(vet2[0]);
            numPecas2 = int.Parse(vet2[1]);
            valorUnitariPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            mult2 = numPecas2 * valorUnitariPeca2;

            soma = mult1 + mult2;

            Console.WriteLine($"VALOR A PAGAR: R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}