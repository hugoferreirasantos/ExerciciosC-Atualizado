using System;

namespace Exercicio1049EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome01 = Console.ReadLine().ToLower();
            string nome02 = Console.ReadLine().ToLower();
            string nome03 = Console.ReadLine().ToLower();

            if(nome01 == "vertebrado")
            {
                if(nome02 == "ave")
                {
                    if(nome03 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if(nome03 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if(nome02 == "mamifero")
                {
                    if (nome03 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (nome03 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if(nome01 == "invertebrado")
            {
                if(nome02 == "inseto")
                {
                    if(nome03 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (nome03 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if(nome02 == "anelideo")
                {
                    if (nome03 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (nome03 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}