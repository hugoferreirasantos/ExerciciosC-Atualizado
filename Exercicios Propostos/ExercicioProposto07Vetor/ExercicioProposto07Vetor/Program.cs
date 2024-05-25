using System;
using System.Globalization;

namespace ExercicioProposto07Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar o vetores com o tamanho:
            string[] nomes = new string[N];
            double[] notas1S = new double[N];
            double[] notas2S = new double[N];

            //Inserir valores dentro dos vetores:
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                notas1S[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                notas2S[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //Ler o vetores notas1S e notas2S e realizar a média:
            double soma = 0.0;
            double maior = 0.0;
            Console.WriteLine("Alnos aprovados: ");
            for (int i = 0; i < N; i++)
            {
                soma = notas1S[i] + notas2S[i];
                double media = (double)(soma) / 2;
                
                if(media >= 6.0)
                {
                    Console.WriteLine($"{nomes[i]}");
                }

            }
        }
    }
}