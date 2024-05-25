using System;
using System.Globalization;

namespace Exercicio1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc, numHoraTrabalhadas;
            double valorHora, salario;

            numFunc = int.Parse(Console.ReadLine());
            numHoraTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numHoraTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numFunc}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}