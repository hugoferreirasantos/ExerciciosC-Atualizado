using System;

namespace SintaxeOpicionalForeacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0].ToUpper();
            }

            Console.WriteLine();

            Console.WriteLine("NOMES LIDOS: ");

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


        }
    }
}