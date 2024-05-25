using System;
using System.Globalization;

namespace Exerciocio1131EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsInter, golsGremio, vitoriaInter = 0, vitoriGremio = 0, empate = 0, quantGenais = 0, cont = 0, cont2 = 0, x = 0;
            bool flag = true;

            while (flag)
            {
                cont = 0;
                cont2 = 0;
                string[] vet = Console.ReadLine().Split(' ');

                golsInter = int.Parse(vet[0]);
                golsGremio = int.Parse(vet[1]);

                //Verificando vitorias e empates:
                if(golsInter > golsGremio)
                {
                    cont = cont + 1;
                    vitoriaInter = vitoriaInter + cont;
                }
                else if (golsGremio > golsInter)
                {
                    cont = cont + 1;
                    vitoriGremio = vitoriGremio + cont;
                }
                else if (golsGremio == golsInter || golsInter == golsGremio)
                {
                    cont = cont + 1;
                    empate = empate + cont;
                }

                cont2 = cont2 + 1;
                quantGenais = quantGenais + cont2;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());

                while (x != 1 && x != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                }

                if(x != 1)
                {
                    flag = false;
                }
                

            }

            //Impressão dos Resultados:
            Console.WriteLine($"{quantGenais} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriGremio}");
            Console.WriteLine($"Empates:{empate}");

             //Condicional de quem venceu mais:
            if(vitoriaInter > vitoriGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriGremio > vitoriaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (vitoriaInter == vitoriGremio || vitoriGremio == vitoriaInter)
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}