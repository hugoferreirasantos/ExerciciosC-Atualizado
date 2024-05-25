using System;
using System.Globalization;

namespace IntroducaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das Variaveis:
            int N;
            double[] vet;

            //Solitação de valor ao usuário: Quantos números serão inseridos no vetor
            N = int.Parse(Console.ReadLine());

            //Instanciação do Vetor com quantidade
            vet = new double[N];

            //Laço FOR: Para inserir valores dentro do vetor
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Laço FOR: Para conferir o valores digitados dentro do vetor
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1",CultureInfo.InvariantCulture));
            }

        }
    }
}