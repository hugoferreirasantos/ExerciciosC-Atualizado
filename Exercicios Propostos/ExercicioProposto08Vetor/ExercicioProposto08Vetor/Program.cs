using System;
using System.Globalization;

namespace ExercicioProposto08Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o vetor com um tamanho:
            double[] alturas = new double[N];
            char[] sexos = new char[N];

            //Inserir os dados dentro dos vetores:
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(s[1].ToUpper());
            }

            //Verificar a meior e a menor altura:
            double maior = alturas[0];
            double menor = alturas[0];
            foreach (var altura in alturas)
            {
                if(altura > maior)
                {
                    maior = altura;
                }
                else if (altura < menor)
                {
                    menor = altura;
                }
            }
            Console.WriteLine($"Menor altura: {menor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior altura: {maior.ToString("F2", CultureInfo.InvariantCulture)}");

            //Media das alturas das mulheres:
            double soma = 0.0;
            int cont = 0;
            for (int i  = 0; i < N; i++)
            {
                if(sexos[i] == 'F')
                {
                    soma = soma + alturas[i];
                    cont++;
                }
            }
            double media = soma / cont;
            Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2", CultureInfo.InvariantCulture)}");

            //Quantidad e Homens e Mulheres:
            int quantM = 0;
            int quantF = 0;

            for (int i = 0; i < N; i++)
            {
                if (sexos[i] == 'M')
                {
                    quantM++;
                }
                else if (sexos[i] == 'F')
                {
                    quantF++;
                }
            }
            Console.WriteLine($"Numero de homens = {quantM}");
            Console.WriteLine($"Numero de mulheres = {quantF}");


        }
    }
}