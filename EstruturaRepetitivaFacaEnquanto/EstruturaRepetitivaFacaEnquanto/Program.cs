using System;
using System.Globalization;

namespace EstruturaRepeticaoFacaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Estrutura While:
             * 
            double C, F;
            char repetir = 'S';
            
            while (repetir == 'S')
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Calculo:
                F = 9.0 * C / 5.0 + 32;
                Console.WriteLine($"Equivalente em Fahrenheit: {F.ToString("F1", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Deseja repetir (S/N) ?");
                repetir = char.Parse(Console.ReadLine());
            }
            
             */

            //Estrutura Do While:

            double C, F;
            char repetir = 'S';

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Calculo:
                F = 9.0 * C / 5.0 + 32;
                Console.WriteLine($"Equivalente em Fahrenheit: {F.ToString("F1", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Deseja repetir (S/N) ?");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 'S');
            









        }
    }
}