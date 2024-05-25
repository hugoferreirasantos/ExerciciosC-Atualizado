using System;

namespace ExercicioProposto06Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir o tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar os vetores com o tamanho:
            int[] idades = new int[N];
            string[] nomes = new string[N];

            //Inserir valores dentro dos vetores:
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                idades[i] = int.Parse(s[1]);
                nomes[i] = s[0];
            }

            //Verificar: Quem é a pessoa mais velha:
            int max = idades[0];
            foreach (var idade in idades)
            {
                if(idade > max)
                {
                    max = idade;
                }
            }

            int indece = Array.IndexOf(idades, max);

            Console.WriteLine($"Pessoa mais velha: {nomes[indece]}");

        }
    }
}