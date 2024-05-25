using System;

namespace ExercicioResolvido03EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] vet = Console.ReadLine().Split(' ');

            //Inserção de valores nas variáveis:
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            //Estrutura Condicional: Trata qual é o menor número entre os 3 inseridos:
            if (x < y && x < z)
            {
                Console.WriteLine($"MENOR = {x}");
            }
            else if (y < z)
            {
                Console.WriteLine($"MENOR = {y}");
            }
            else
            {
                Console.WriteLine($"MENOR = {z}");
            }





        }
    }
}