using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Base, Altura, Area, Perimetro, Diagonal;

            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Base * Altura;
            Perimetro = (2.0 * Base) + (2.0 * Altura);
            Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));

            Console.WriteLine($"AREA = {Area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {Perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {Diagonal.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}