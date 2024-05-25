using System;
using System.Globalization;

namespace Exercicio1114EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int condicional = 1,senha;

            while (condicional != 0)
            {
                senha = int.Parse(Console.ReadLine());
                
                if(senha  == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    condicional = 0;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }

            }

        }
    }
}