using System;

namespace Exercicio1046EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            //Condicional:
            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else if(horaInicial > horaFinal)
            {
                duracao = (24 - horaInicial) + horaFinal;
            }
            else
            {
                duracao = 24;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");


        }
    }
}