using System;
using System.Globalization;

namespace Exercicio1048EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario = 0.00, reajusteGanho = 0.00, percentual = 0.00;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario >=0.00 && salario <= 400.00)
            { 
                reajusteGanho = salario * 0.15;
                novoSalario = salario + reajusteGanho;
                percentual = 0.15 * 100;
            }
            else if(salario >= 400.01 && salario <= 800.00)
            {
                reajusteGanho = salario * 0.12;
                novoSalario = salario + reajusteGanho;
                percentual = 0.12 * 100;
            }
            else if(salario >= 800.01 && salario <= 1200.00)
            {
                reajusteGanho = salario * 0.10;
                novoSalario = salario + reajusteGanho;
                percentual = 0.10 * 100;
            }
            else if(salario >= 1200.01 && salario <= 2000.00)
            {
                reajusteGanho = salario * 0.07;
                novoSalario = salario + reajusteGanho;
                percentual = 0.07 * 100;
            }
            else if(salario > 2000.00)
            {
                reajusteGanho = salario * 0.04;
                novoSalario = salario + reajusteGanho;
                percentual = 0.04 * 100;
            }

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual} %");

        }
    }
}