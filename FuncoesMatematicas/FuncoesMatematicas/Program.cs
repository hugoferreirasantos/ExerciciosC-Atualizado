using System;
using System.Globalization;

namespace FuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A = Math.Sqrt(x) - Variável A recebe a raiz quadrada de x;
             A = Math.Pow(x) - Variável A recebe o resultado de X elevado a Y;
             A = Math.Abs(x) - Variável A recebe o valor absoluto de X;

            ___________________________________________________________________________________________________

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine($"Raiz quadrada de {x} = {A}");
            Console.WriteLine($"Raiz quadrada de {y} = {B}");
            Console.WriteLine($"Raiz quadrada de 25 = {C}");

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine($"{x} elevado a {y} = {A}");
            Console.WriteLine($"{x} elevado ao quadrado = {B}");
            Console.WriteLine($"5 elevado ao quadrado = {C}");

            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine($"Valor absoluto de {y} = {A}");
            Console.WriteLine($"Valor absoluto de {z} = {B}");

            Console.ReadLine();

             */

            //Exercício: Calcular a formula de delta:

            double a, b, c;
            double x1, x2;

            Console.WriteLine("CALCULO DA FORMULA : DELTA");
            Console.WriteLine();

            Console.WriteLine("Digite um valor para 'a' ");
            double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um valor para 'b' ");
            double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um valor para 'c' ");
            double valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = valorA;
            b = valorB;
            c = valorC;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            x1 = ((-b + Math.Sqrt(delta)) / (2.0 * a));
            x2 = ((-b - Math.Sqrt(delta)) / (2.0 * a));

            Console.WriteLine($"O valor de a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"O resultado de delta é: {delta}");
            Console.WriteLine($"O resultado de X1 é: {x1.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O resultado de X2 é: {x2.ToString("F1", CultureInfo.InvariantCulture)}");





        }
    }
}
