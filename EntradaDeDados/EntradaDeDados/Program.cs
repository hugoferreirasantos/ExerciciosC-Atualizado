using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Entrada de Dados: Parte 01
             string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];


            Console.WriteLine("====================================================");

            Console.WriteLine("Você digitou: ");
            Console.WriteLine();
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            -------------------------------------------------------------------------------------

             int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine();

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " +idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));



             */

            //Exercício:

            Console.WriteLine("Entre com o seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            byte quartos = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com um preço de um produto");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");

            string[] vet = Console.ReadLine().Split(' ');
            string UltimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Dados que você digitou");
            Console.WriteLine();
            Console.WriteLine("Nome Completo: " + nome);
            Console.WriteLine("Quantidade de quartos: " + quartos);
            Console.WriteLine("Preço do Produto: " + " R$ " + precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último Nome: " + UltimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));










        }

    }
}