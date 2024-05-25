using System;
using System.Globalization;

namespace Exercicio01EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do metro quadrado: ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PREÇO = {preco.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}