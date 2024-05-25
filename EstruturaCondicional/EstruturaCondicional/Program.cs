using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Estrutura IF simples
            int x = 5;

            Console.WriteLine("Bom dia");

            if (x < 0)
            {

                Console.WriteLine("Boa tarde");

            } else
            {

            }

            Console.WriteLine("Bom Noite");
            
            Estrutura IF composta:

            int horas;

            Console.WriteLine("Quantas Horas ?");
            horas = int.Parse(Console.ReadLine());

            if(horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa tarde");
            }


            //Encadeamento de IF 's:

            int horas;

            Console.WriteLine("Quantas Horas ?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                if(horas < 18)
                {
                    Console.WriteLine("Boa tade");
                }
                else
                {
                    Console.WriteLine("Boa noite");
                }
            }

            ------------------------------------------------

            int horas;

            Console.WriteLine("Quantas Horas ?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (horas < 18){
                Console.WriteLine("Boa tade");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

             */

            int horas;

            Console.WriteLine("Quantas Horas ?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (horas < 18)
            {
                Console.WriteLine("Boa tade");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }










        }
    }
}