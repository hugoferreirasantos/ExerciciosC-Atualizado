using System;

namespace Exercicio1042EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, menor1, menor2, menor3;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if(n1 < n2 && n1 < n3)
            {
                menor1 = n1;
                if(n2 < n3)
                {
                    menor2 = n2;
                    menor3 = n3;
                }
                else
                {
                    menor2 = n3;
                    menor3 = n2;
                }
            }
            else if(n2 < n1 && n2 < n3)
            {
                menor1 = n2;
                if(n1 < n3)
                {
                    menor2 = n1;
                    menor3 = n3;
                }
                else
                {
                    menor2 = n3;
                    menor3 = n1;
                }
            }
            else
            {
                menor1 = n3;
                if(n2 < n1)
                {
                    menor2 = n2;
                    menor3 = n1;
                }
                else
                {
                    menor2 = n1;
                    menor3 = n2;
                }
            }

            //Emissão dos números:

            Console.WriteLine($"{menor1}");
            Console.WriteLine($"{menor2}");
            Console.WriteLine($"{menor3}");
            Console.WriteLine();
            Console.WriteLine($"{n1}");
            Console.WriteLine($"{n2}");
            Console.WriteLine($"{n3}");

        }
    }

}