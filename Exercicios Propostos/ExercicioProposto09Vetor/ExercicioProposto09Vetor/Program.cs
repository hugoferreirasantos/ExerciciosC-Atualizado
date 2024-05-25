using System;
using System.Globalization;

namespace ExercicioProposto09Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar os vetores com um tamanho:
            string[] produtos = new string[N];
            double[] precoDeCompras = new double[N];
            double[] precoDeVendas = new double[N];

            //Inserir valores dentro dos vetores:
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = s[0];
                precoDeCompras[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoDeVendas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //Calcular o lucro total e o número de mercadorias que proporcionaram lucro abaixo de 10%, entre 10% e 20% e acima de 20%:
            double lucroTotal = 0.0;
            int abaixoDe10 = 0;
            int entre10e20 = 0;
            int acimaDe20 = 0;


            for (int i = 0; i < N; i++)
            {
                double lucro = (precoDeVendas[i] - precoDeCompras[i]) / precoDeCompras[i] * 100.0;
                lucroTotal += precoDeVendas[i] - precoDeCompras[i];
                if (lucro < 10.0)
                {
                    abaixoDe10++;
                }
                else if (lucro <= 20.0)
                {
                    entre10e20++;
                }
                else
                {
                    acimaDe20++;
                }
            }


            //Total de Compras e Vendas:
            double totalDeCompras = 0.0;
            double totalDeVendas = 0.0;
            for (int i = 0; i < N; i++)
            {
                totalDeCompras = totalDeCompras + precoDeCompras[i];
                totalDeVendas = totalDeVendas + precoDeVendas[i];
            }

            Console.WriteLine($"Lucro abaixo de 10%: {abaixoDe10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {entre10e20}");
            Console.WriteLine($"Lucro acima de 20%: {acimaDe20}");
            Console.WriteLine($"Valor total de compra: {totalDeCompras.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda: {totalDeVendas.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}