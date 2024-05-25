using System;

namespace ExercicioProposto02Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Definir tamanho do vetor:
            N = int.Parse(Console.ReadLine());

            //Instânciar um vetor com um tamanho:
            int[] numeros = new int[N];

            //Inserção de dados dentro do vetor:
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            //Encontrar e contabilizar os números pares:
            int cont = 0;
            foreach (var numero in numeros)
            {
                if(numero % 2 == 0)
                {
                    Console.Write($"{numero} ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);




        }
    }
}