using System;
using System.Globalization;

namespace Exercicio1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int  notas100, notas50, notas20, notas10, notas5, notas2,moeda1,moeda50,moeda25,moeda10,moeda5,moeda01;
            double N, Divnotas100, Divnotas50, Divnotas20, Divnotas10, Divnotas5, Divnotas2, Divmoeda1, Divmoeda50, Divmoeda25, Divmoeda10, Divmoeda5, Divmoeda01;
            double Rnotas100, Rnotas50, Rnotas20, Rnotas10, Rnotas5, Rnotas2, Rmoeda1, Rmoeda50, Rmoeda25, Rmoeda10, Rmoeda5, Rmoeda01;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Divnotas100 = N / 100;
            notas100 = (int) Divnotas100;
            Rnotas100 = N % 100;

            Divnotas50 = Rnotas100 / 50;
            notas50 = (int)Divnotas50;
            Divnotas50 = Rnotas100 % 100; 
            Rnotas50 = Divnotas50 % 50;

            Divnotas20 = Rnotas50 / 20;
            notas20 = (int) Divnotas20;
            Divnotas20 = Rnotas50 % 50;
            Rnotas20 = Divnotas20 % 20;

            Divnotas10 = Rnotas20 / 10;
            notas10 = (int)Divnotas10;
            Divnotas10 = Rnotas20 % 20;
            Rnotas10 = Divnotas10 % 10;

            Divnotas5 = Rnotas10 / 5;
            notas5 = (int)Divnotas5;
            Divnotas5 = Rnotas10 % 10;
            Rnotas5 = Divnotas5 % 5;

            Divnotas2 = Rnotas5 / 2;
            notas2 = (int)Divnotas2;
            Divnotas2 = Rnotas5 % 5;
            Rnotas2 = Divnotas2 % 2;

            Divmoeda1 = Rnotas2 / 1;
            moeda1 = (int)Divmoeda1;
            Divmoeda1 = Rnotas2 % 2;
            Rmoeda1 = Divmoeda1 % 1;

            // Multiplica o resto por 100 para obter o valor em centavos
            Rmoeda1 = Rmoeda1 * 100;


            // Divide o valor em centavos por 50 para obter o número de moedas de 50 centavos
            Divmoeda50 = Rmoeda1 / 50;
            moeda50 = (int)Divmoeda50;
            // Usa o operador % para obter o resto da divisão por 50
            Rmoeda50 = Rmoeda1 % 50;

            // Divide o resto por 25 para obter o número de moedas de 25 centavos
            Divmoeda25 = Rmoeda50 / 25;
            moeda25 = (int)Divmoeda25;
            // Usa o operador % para obter o resto da divisão por 25
            Rmoeda25 = Rmoeda50 % 25;

            // Divide o resto por 10 para obter o número de moedas de 10 centavos
            Divmoeda10 = Rmoeda25 / 10;
            moeda10 = (int)Divmoeda10;
            // Usa o operador % para obter o resto da divisão por 10
            Rmoeda10 = Rmoeda25 % 10;

            // Divide o resto por 5 para obter o número de moedas de 5 centavos
            Divmoeda5 = Rmoeda10 / 5;
            moeda5 = (int)Divmoeda5;
            // Usa o operador % para obter o resto da divisão por 5
            Rmoeda5 = Rmoeda10 % 5;

            // Divide o resto por 1 para obter o número de moedas de 1 centavo
            Divmoeda01 = Rmoeda5 / 1;
            moeda01 = (int)Divmoeda01;


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{notas100} nota(s) de R$ 100.00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50.00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20.00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10.00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5.00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");




        }
    }
}