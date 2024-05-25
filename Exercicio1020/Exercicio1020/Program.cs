using System;

namespace Exercicio1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoInformado,calculoMes;
            double calculoAno, calculodia, CalculoRestoAno, CalculoRestoMes;


            anoInformado = int.Parse(Console.ReadLine());

            calculoAno = anoInformado / 365;
            CalculoRestoAno = anoInformado % 365;

            calculoMes =  (int) CalculoRestoAno / 30;
            CalculoRestoMes = CalculoRestoAno % 30;

            calculodia = CalculoRestoMes;


            Console.WriteLine($"{calculoAno} ano(s)");
            Console.WriteLine($"{calculoMes} mes(es)");
            Console.WriteLine($"{calculodia} dia(s)");


        }
    }
}
